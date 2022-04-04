using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum Platform {PC, Xbox, Switch, Playstation, Android, iOS}
    public enum ControlType {Keyboard, Controller}
    public enum Color {Light, LightGray, Gray, Dark, Brick, Vermillion, Gold, Electric, Peridot, Lime, Clover, Jade, Mint, Blue, Indigo, Violet, Purple}
    public enum MenuType {Function, Armor, Color}
    public enum PromptType {ButtonN, ButtonE, ButtonS, ButtonW, LookInput, Start, Select, LeftBumper, RightBumper }
    public enum SelectedMenu {Initial, Main, Profile, Multiplayer, Settings}
    public enum SelectedEdge {Social, Matchmaking, Quickmenu, Creative, Settings}
    public enum WeaponType {Hitscan, Projectile, Melee}
    public enum FireType {FullAuto, SemiAuto, Hold, Toggle}
    public enum Avatar {Smug, Astute}
}
