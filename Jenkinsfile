pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Build Odin Project Start'
        bat 'dotnet build %WORKSPACE%\\OdinProtocol.sln --configuration Release'
      }
    }

    stage('Deploy') {
      steps {
        echo 'Deploy Odin'
        input 'Is it Ok?'
      }
    }

    stage('Arshive') {
      steps {
        archiveArtifacts(artifacts: 'bin\\Release\\net6.0\\*.*', fingerprint: true)
      }
    }

  }
  environment {
    dotnet = 'C:\\\\Program Files\\\\dotnet\\\\dotnet.exe'
  }
}