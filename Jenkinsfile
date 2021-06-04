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
    }
}
