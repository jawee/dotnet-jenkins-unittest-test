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
        dotnetTest(project: 'MyLibrary.Tests/MyLibrary.Tests.csproj', blame: true)
      }
    }

  }
}