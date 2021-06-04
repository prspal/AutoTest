agentName = "linux"
agentLabel = "${println 'Right Now the Agent Name is ' + agentName; return agentName}"

pipeline {
    agent none

    stages {
 
  
        stage('Final1') {
            agent { label agentLabel }

            steps {
                echo "The Node Name is: ${node_name}"

                script {
                    println "\n\n-- Running on machine: " + "hostname".execute().text
                    agentName = "windows"
                }
            }
        }
      stage('Final2') {
            agent { label agentLabel }
            echo "The Node Name is: ${node_name}"

            steps {
                echo "The Node Name is: ${node_name}"
                script {
                    println agentLabel
                    println agentName
                    println "\n\n-- Running on machine: " + "hostname".execute().text
                }
            }
        }

    }
}
