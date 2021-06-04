pipeline {
    agent any 
    stages {
        stage('Build') { 
                   steps {

            echo "I'm in satage: $current_stage"
                   }
        }
        stage('Test') { 
            steps {
                echo "TEST"
            }
        }
        stage('Deploy') { 
            steps {
                echo "DEPLOY"
            }
        }
    }
}
