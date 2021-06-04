agentName = "linux"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"
cmd = ""
pipeline {
    agent none 
    stages { 
        stage('One_1') { 
            agent { label agentLabel }
            steps { 
               echo "Switch Agents"
               script{
                   sh 'hostname'
                   if(isUnix()){
                       echo "Linux -> Windows"
                       agentName = "windows"
                       hostname = env.HOSTNAME
                   }
                   else{
                       echo "Windows-> Linux"
                       agentName = "linux"
                       hostname = env.HOSTNAME
                       
    //                 sh "echo https://s3.amazonaws.com/lambda-tunnel/LT_Linux.zip"
                   }
               }               

               
           }
        }
        stage('One_2'){
           agent { label agentName }
           steps {
               script {
                   sh 'hostname'
                    println agentLabel
                    println agentName
                }
               echo "Hostname: ${env.COMPUTERNAME}"
           }

       }       
       stage('Git Code') { 
           agent { label agentName }

            steps {
//                 input "Continue"
                   echo "Get git code"
//                   git 'https://github.com/prspal/AutoTest.git'
            }
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
