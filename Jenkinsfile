agentName = "windows"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"

pipeline {
    agent none

    stages {
 
  
        stage('Final1') {
            agent { label agentLabel }

            steps {
                echo "The Node Name is: ${node_name}"

                script {
                     agentName = "linux"
                }
            }
        }
      stage('Final2') {
            agent { label agentLabel }
 
            steps {
                echo "The Node Name is: ${node_name}"
                script {
                    println agentLabel
                    println agentName
                 }
            }
        }

    }
}
