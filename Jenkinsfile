agentName = "windows"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"

pipeline {
    agent none

    stages {
 
  
        stage('Final1') {
            agent { label agentLabel }

            steps {
                script {
                    sh 'hostname'
                    agentName = "windows"
                }
            }
        }
      stage('Final2') {
            agent { label agentLabel }

            steps {
                script {
                    println agentLabel
                    println agentName
                    sh 'hostname'
                }
            }
        }

    }
}
