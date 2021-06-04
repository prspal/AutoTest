pipeline {
    agent any 
    stages {
        stage('One') { 
           steps {
                echo "Starting Input test"
            }
        }
        stage('Two') { 
            steps {
                input "Continue"
            }
        }
        stage('Three') { 
            when {
                not {
                    branch "master"
                }
            }
            steps {
                echo "Three"
            }
        }
        
        stage('Four') {
             parallel { 
                       stage('Unit Test') {
                       steps {
                            echo "Running the unit test..."
                            }
                       }
                        stage('Integration test') {
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
