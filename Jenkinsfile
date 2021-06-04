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
            When {
                not {
                    branch "master"
                }
            }
            steps {
                echo "Three"
            }
        }
    }
}
