﻿using UnityEngine;

public enum ItemType { Equipment, Readable, Valuable, Key, Potion, Oil }
public enum SFXType { ItemEquipped, PageChanged, OpenReadable, CloseReadable }
public enum VolumeType { Music, Effects, Physics }
public enum CameraType { Player, Inventory, FirstPerson, DiceBoard, Puppet }
public enum ScreenType { Main, Inventory, Menu, Archives, Puppet, DiceBoard }
public enum UIType { Main, Inventory, Menu, Archives, DiceBoard, Puppet, PlayerStats }
public enum PotionType { Strength, Health }
public enum GearSlot { Chest, Head, RightHand, LeftHand }
public enum BaseStat { Vitality, Strength, Endurance, HitRolls, ScoreToHit }
public enum EquipmentBonus { Armor, HitRolls, ToHit, ToWound, Vitality, Strength, Endurance }
public enum DoorState { Opened, Closed, Locked }
public enum DiceValue { Broken = 0, One, Two, Three, Four, Five, Six }
public enum DiceThrowType { None, Automatic, Manual, Thrown }
public enum ThrowActionType { HealingPotion, StrengthPotion, LootChest, Touch, Wound }
public enum ThrowActionPerformer { Player, Ennemy }
public enum DiceColor { Red, Green, Blue, Black, White, Gold }
public enum DiceOutlineType { None, Broken, Success, Failure, Selected }
public enum LootableOutlineType { Lightable, Readable, Common, Uncommon, Rare, Epic, Legendary }

public static class Constants
{
    //File paths
    public static string SaveFilesPath { get; private set; } = Application.persistentDataPath + "/Saves";
    public static string TemporaryExtractedSavesPath { get; private set; } = SaveFilesPath + "/Temp";
    public static string PreferencesFilePath { get; private set; } = Application.persistentDataPath;
    public static string prefabsPath { get; private set; } = "Prefabs/Lootables/";
    public static string skinsPath { get; private set; } = "Prefabs/Skins/";

    public static string PreferencesFilename { get; private set; } = "userprefs.json";

    //File extensions
    public static string SaveFilesExtension { get; private set; } = ".json";
    public static string ZippedSavesExtension { get; private set; } = ".qsf";
    public static string ScreenshotsExtension { get; private set; } = ".png";

    //Tags
    public static string SaveTag { get; private set; } = "Savable";
    public static string DiceBoardTag { get; private set; } = "DiceBoard";

    //Savefiles serialized fields
    public static string SFSerializedNameField { get; private set; } = "Name";
    public static string SFSerializedDateField { get; private set; } = "Date";
    public static string SFSerializedChapterField { get; private set; } = "Chapter";
    public static string SFSerializedPlayTimeField { get; private set; } = "PlayTime";
    public static string SFSerializedSceneField { get; private set; } = "Scene";
    public static string SFSerializedPlayerPositionField { get; private set; } = "PlayerPosition";
    public static string SFSerializedDestroyedItemsField { get; private set; } = "DestroyedItems";
    public static string SFSerializedLitLightsField { get; private set; } = "LitLights";
    public static string SFSerializedOpenedChestsField { get; private set; } = "OpenedChests";
    public static string SFSerializedDoorsStatesField { get; private set; } = "DoorsStates";
    public static string SFSerializedUnlockedDoorsField { get; private set; } = "UnlockedDoors";
    public static string SFSerializedOilAmountField { get; private set; } = "OilAmount";
    public static string SFSerializedGoldAmountField { get; private set; } = "GoldAmount";
    public static string SFSerializedKeysField { get; private set; } = "Keys";
    public static string SFSerializedInventoryContentField { get; private set; } = "InventoryContent";
    public static string SFSerializedArchivesField { get; private set; } = "Archives";
    public static string SFSerializedPlayerStatsField { get; private set; } = "PlayerStats";
    public static string SFSerializedPlayerStatsHealthPointsField { get; private set; } = "HealthPoints";
    public static string SFSerializedPlayerStatsVitalityField { get; private set; } = "Vitality";
    public static string SFSerializedPlayerStatsEnduranceField { get; private set; } = "Endurance";
    public static string SFSerializedPlayerStatsStrengthField { get; private set; } = "Strength";
    public static string SFSerializedPlayerStatsHitRollsField { get; private set; } = "HitRolls";
    public static string SFSerializedPlayerStatsScoreToHitField { get; private set; } = "ScoreToHit";
}
