agentName = "master"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"
cmd = ""
pipeline {
    agent {
        node {
            label agentName
        }
    }

//     tools { 
//         maven 'maven3' 
//     }

    options {
        buildDiscarder logRotator( 
                    daysToKeepStr: '15', 
                    numToKeepStr: '10'
            )
    }

    environment {
        APP_NAME = "AutoTest" 
        APP_ENV  = "Demo"
        WEBUI_TESTS = "DataDrivenTests.DataDrivenTestFixture"
    }

    
    
    stages { 
        stage('Cleanup Workspace') {
            steps {
                cleanWs()
                 echo "Cleaned Up Workspace ${env.JOB_NAME} "
            }
        }
       stage('Git Code') { 
//            agent { label agentName }

            steps { 
                echo "Get git code"
                checkout([
                    $class: 'GitSCM', 
                    branches: [[name: '*/master']], 
                    userRemoteConfigs: [[url: 'https://github.com/nunit/nunit-csharp-samples.git']]
                ])            }
        }
        stage('Build code') { 
//             when {
//                 not {
//                     branch "master"
//                 }
//             }
            steps {
                bat "echo Restore Nuget Packages"
                bat '"C:\\opt\\bin\\nuget.exe" restore samples.sln'
                echo "Build the package"
                bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\BuildTools\\MSBuild\\Current\\Bin\\msbuild.exe" /t:build samples.sln'
            }
        }
        
        stage('Automation') {
             parallel { 
                       stage('NUnit Test') {
                       steps {
                            echo "Running the unit test..."
                            bat  'C:\opt\nunit3\nunit-console\nunit3-console.exe DataDrivenTests/bin/Debug/DataDriven.Tests.dll  ExpectedExceptionExample/bin/Debug/ExpectedExceptionExample.Tests.dll   --result=%WORKSPACE%\TestResult.xml --where "class =~ /%RUN_WEBUI_TEST%/"'
                            }
                       }
                        stage('WebUI test') {
                          steps {
                                echo "Running the integration test..."
                                 }
                            }
                       }
          }
    }
}
