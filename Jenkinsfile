pipeline {
    agent any 
    stages {
        stage('One') { 
           steps {
                echo "Test SH cmd on windows"
                sh "echo https://s3.amazonaws.com/lambda-tunnel/LT_Linux.zip"

            }
        }
        stage('Git Code') { 
            steps {
//                 input "Continue"
                   echo "Get git code"
                  git 'https://github.com/prspal/AutoTest.git'
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
