agentName = "master"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"
cmd = ""
pipeline {
    agent {label agentName} 
    stages { 
        /*
        stage('One_1') { 
            agent { label agentLabel }
            steps { 
               echo "Switch Agents"
               script{
                   if(isUnix()){
                       echo "Linux -> Windows"
                       agentName = "windows"
                      sh 'hostname'
                   }
                   else{
                       echo "Windows-> Linux"
                       agentName = "linux"
                      bat 'hostname'
                       
    //                 sh "echo https://s3.amazonaws.com/lambda-tunnel/LT_Linux.zip"
                   }
               }               

               
           }
        }
        stage('One_2'){
           agent { label agentName }
           steps {
               script {
                   if(isUnix()){
                       sh 'hostname'
                   }
                   else{
                       bat 'hostname'
                   }
                }
               echo "Hostname: ${env.COMPUTERNAME}"
           }

       }       
       */

        stage('Cleanup Workspace') {
            steps {
                cleanWs()
                sh """
                echo "Cleaned Up Workspace for ${APP_NAME}"
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
