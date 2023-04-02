pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Build Odin Project'
      }
    }

    stage('Linux Test') {
      steps {
        echo 'Test in Linux Os'
      }
    }

    stage('Deploy Stage') {
      steps {
        echo 'Deploy to staging environment'
        input 'Ok to deploy to production'
      }
    }

    stage('Deploy Production') {
      steps {
        echo 'Deploy to Prod '
      }
    }

  }
  post {
    always {
      archiveArtifacts(artifacts: 'bin/Debug/net6.0/OdinProtocol.exe', fingerprint: true)
    }

    failure {
      mail(to: 'mdevmaleki@gmail.com', subject: "Failed Pipeline ${currentBuild.fullDisplayName}", body: " For details about the failure, see ${env.BUILD_URL}")
    }

  }
}
