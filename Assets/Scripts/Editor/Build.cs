using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Build {
  static string[] scenes = { 
    "Assets/Karting/Scenes/IntroMenu.unity", 
    "Assets/Karting/Scenes/MainScene.unity", 
    "Assets/Karting/Scenes/LoseScene.unity", 
    "Assets/Karting/Scenes/WinScene.unity" 
  };

  static void MacOs() {
    BuildPipeline.BuildPlayer(scenes, "./Builds/game.osx", BuildTarget.StandaloneOSX, BuildOptions.None);      
  }

  static void Windows() {
    BuildPipeline.BuildPlayer(scenes, "./Builds/game_x64.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);      
  }
}
