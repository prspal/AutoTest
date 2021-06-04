pipeline {
    agent any 
    stages {
        stage('One') { 
           steps {
                echo "Starting Input test"
            }
        }
        stage('Git Code') { 
//             steps {
//                 input "Continue"
//             }
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
//                           agent {
//                                 docker {
//                                         reuseNode true
//                                         image 'ubuntu'
//                                        }
//                                 }
                          steps {
                                echo "Running the integration test..."
                                 }
                            }
                       }
          }
    }
}
