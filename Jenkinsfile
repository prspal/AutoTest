pipeline {
    agent any 
    stages {
        stage('Build') { 
            def current_stage = "Build"
            echo "I'm in satage: $current_stage"
 
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
