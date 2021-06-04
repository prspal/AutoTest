agentName = "master"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"
cmd = ""
pipeline {
    agent {
        node {
            label agentName
        }
    }

    tools { 
        maven 'maven3' 
    }

    options {
        buildDiscarder logRotator( 
                    daysToKeepStr: '15', 
                    numToKeepStr: '10'
            )
    }

    environment {
        APP_NAME = "AutoTest" 
        APP_ENV  = "Demo"
    }

    
    
    stages { 
        stage('Cleanup Workspace') {
            steps {
                cleanWs()
                sh """
                echo "Cleaned Up Workspace ${env.JOB_NAME} "
                """
            }
        }
       stage('Git Code') { 
//            agent { label agentName }

            steps { 
                echo "Get git code"
                checkout([
                    $class: 'GitSCM', 
                    branches: [[name: '*/master']], 
                    userRemoteConfigs: [[url: 'https://github.com/prspal/AutoTest.git']]
                ])            }
        }
        stage('Build code') { 
//             when {
//                 not {
//                     branch "master"
//                 }
//             }
            steps {
                echo "Three"
            }
        }
        
        stage('Automation') {
             parallel { 
                       stage('BVT Test') {
                       steps {
                            echo "Running the unit test..."
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
