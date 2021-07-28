node("Windows") {
  stage("Checkout") {
    checkout scm
  }
  stage("Build Unity Project") {
    powershell """
       & "C:\\Program Files\\Unity\\Hub\\Editor\\2020.3.14f1\\Editor\\Unity.exe" -quit -bachmode -projectPath \$PWD -executeMethod Build.Windows
    """
  }

  stage("Stage Build") {
    archiveArtifacts artifacts: 'Builds/game_x64*', fingerprint: true
  }
}
