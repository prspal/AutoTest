agentName = "Windows"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"

pipeline {
    agent none

    stages {
        stage('Prep') {
            steps {
                script {
                    agentName = "linux"
                }
            }
        }
        stage('Checking') {
            steps {
                script {
                    println agentLabel
                    println agentName
                }
            }
        }
        stage('Final1') {
            agent { label agentLabel }

            steps {
                script {
                    sh 'hostname'
                    agentName = "linux"
                }
            }
    }
      stage('Final2') {
            agent { label agentLabel }

            steps {
                script {
                    println agentLabel
                    println agentName
                }
            }
    }

    }
}
