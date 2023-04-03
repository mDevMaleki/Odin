pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Build Odin Project Start'
        bat 'dotnet build %WORKSPACE%\\OdinProtocol.sln --configuration Release'
      }
    }

  }
  environment {
    dotnet = 'C:\\\\Program Files\\\\dotnet\\\\dotnet.exe'
  }
}