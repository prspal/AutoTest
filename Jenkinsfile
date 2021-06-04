agentName = "linux"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"

pipeline {
    agent none 
    stages {
        stage('One_0'){
           agent { label agentLabel }
           steps {
               script {
                    println agentLabel
                    println agentName
                    sh 'hostname'
                }
            }

        }      
        stage('One_1') { 
            agent { label agentLabel }
           steps { 
               echo "Switch Agents"
               script{
                   if(isUnix()){
                       echo "Linux -> Windows"
                       agentName = "windows"
                   }
                   else{
                       echo "Windows-> Linux"
                       agentName = "linux"
    //                 sh "echo https://s3.amazonaws.com/lambda-tunnel/LT_Linux.zip"
                   }
               }               

               
           }
        }
        stage('One_2'){
           agent { label agentName }
           steps {
               script {
                    println agentLabel
                    println agentName
                    sh 'hostname'
                }
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
