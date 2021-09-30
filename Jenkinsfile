pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        dotnetBuild(project: 'MyLibrary/MyLibrary.csproj')
      }
    }

    stage('Test') {
      steps {
        sh 'dotnet test MyLibrary.Tests/MyLibrary.Tests.csproj --collect:"XPlat Code Coverage"'
      }
    }

  }
}