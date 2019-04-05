﻿namespace AAEmu.Game.Models.Game.Items.Actions
{
    // TODO at X2::GameClient::ApplyItemTaskToSelf
    public enum ItemTaskType : byte
    {
        Invalid = 0,
        Destroy = 1,
        AboxDestroy = 2,
        Repair = 3,
        DurabilityLoss = 4,
        SwapItems = 5,
        Split = 6,
        SplitCofferItems = 7,
        SwapCofferItems = 8,
        Loot = 9,
        LootAll = 10,
        Gm = 11,
        GameRuleReset = 12,
        ConsumeSkillSource = 13, // 303-consume-skill-source
        DoodadCreate = 14, // 303-doodad-create
        DoodadRemove = 15,
        DoodadItemChanger = 16,
        DoodadInteraction = 17,
        DoodadCattleFeed = 18,
        UpgradeSkill = 19,
        AbilityChange = 20,
        AbilityReset = 21,
        BuyPriestBuff = 22,
        Teleport = 23,
        CapturePet = 24,
        RecoverDoodadItem = 25, // 508-recover-doodad-item
        MateCreate = 26,
        CraftActSaved = 27,
        CraftPaySaved = 28,
        CraftPickupProduct = 29,
        CraftCancel = 30,
        HouseCreation = 31, // 303-house-creation
        HouseDeposit = 32,
        HouseBuilding = 33,
        PickupBloodstain = 34,
        AutoLootDoodadItem = 35, // 316-autoloot-doodad-item
        QuestStart = 36, // 401-quest-start
        QuestComplete = 37, // 402-quest-complete
        QuestSupplyItems = 38, // 405-quest-supply-items
        QuestRemoveSupplies = 39, // 402-403-404-405-quest-remove-supplies
        SkillReagents = 40,
        SkillEffectConsumption = 41,
        SkillEffectGainItem = 42,
        SkillEffectGainItemWithPos = 43,
        SkillEffectSiegeTicket = 44,
        SkillEffectExpToItem = 45,
        Auction = 46,
        Mail = 47,
        Trade = 48,
        EnchantMagical = 49,
        EnchantPhysical = 50,
        GetCoinByItem = 51,
        GetItemByCoin = 52,
        StoreSell = 53, // 315-store-sell
        StoreBuy = 54, // 313-314-store-buy
        TodReward = 55,
        GainItemWithUcc = 56,
        ImprintUcc = 57,
        RepairPets = 58,
        MateDeath = 59,
        Shipyard = 60, // 303-shipyard
        SkillsReset = 61,
        DropBackpack = 62,
        UseRelic = 63,
        UseIndependenceRelic = 64,
        Conversion = 65, // 304-conversion
        Seize = 66,
        ReturnSeized = 67,
        DemoDressOff = 68,
        DemoDressOn = 69,
        DemoClearBag = 70,
        DemoFillBag = 71,
        SlaveDeath = 72,
        ExpeditionCreation = 73,
        RepairSlaves = 74,
        ExpandBag = 75,
        ExpandBank = 76,
        RenewEquipment = 77,
        LifespanExpiration = 78,
        RecoverExp = 79,
        SpawnerUpdate = 80,
        UpdateSummonSlaveItem = 81,
        UpdateSummonMateItem = 82,
        DepositMoney = 83,
        WithdrawMoney = 84,
        DeliverItemToOthers = 85,
        SetSlavePosition = 86,
        SetBountyMoney = 87,
        PayBountyMoney = 88,
        ConvertFish = 89,
        Fishing = 90,
        SellHouse = 91,
        BuyHouse = 92,
        SaveMusicNotes = 93,
        ItemLock = 94,
        ItemUnlock = 95,
        ItemUnlockExcess = 96,
        GradeEnchant = 97,
        RechargeBuff = 98,
        Socketing = 99,
        Dyeing = 100,
        ConsumeIndunTicket = 101,
        ExpandExpert = 102,
        Exchange = 103,
        SellBackpack = 104,
        SellSpecialty = 105,
        AskMould = 106,
        TakeMould = 107,
        FactionDeclareHostile = 108,
        EditCosmetic = 109,
        ChangeAutoUseAaPoint = 110,
        ConvertItemLook = 111,
        ChangeExpertLimit = 112,
        Sknize = 113,
        ItemTaskThistimeUnpack = 114,
        BuyPremiumService = 115,
        BuyAaPoint = 116
    }
}