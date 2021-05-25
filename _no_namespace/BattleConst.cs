public class BattleConst : ScriptableObject // TypeDefIndex: 6910
{
	// Fields
	[SerializeField] // RVA: 0x160060 Offset: 0x160161 VA: 0x160060
	public float Hard_CriticalRate; // 0x18
	[SerializeField] // RVA: 0x160070 Offset: 0x160171 VA: 0x160070
	public float Easy_DamageRate; // 0x1C
	[SerializeField] // RVA: 0x160080 Offset: 0x160181 VA: 0x160080
	public float DamageRandomFactor; // 0x20
	[SerializeField] // RVA: 0x160090 Offset: 0x160191 VA: 0x160090
	public float AttributeDamageRate; // 0x24
	[SerializeField] // RVA: 0x1600A0 Offset: 0x1601A1 VA: 0x1600A0
	public float AttributeDefenseRate; // 0x28
	[SerializeField] // RVA: 0x1600B0 Offset: 0x1601B1 VA: 0x1600B0
	public float PartyDamageRate; // 0x2C
	[SerializeField] // RVA: 0x1600C0 Offset: 0x1601C1 VA: 0x1600C0
	public float SuperArmerDefenseRate; // 0x30
	[SerializeField] // RVA: 0x1600D0 Offset: 0x1601D1 VA: 0x1600D0
	public BattleConst.ShieldEffect ShieldEffect_Sword; // 0x38
	[SerializeField] // RVA: 0x1600E0 Offset: 0x1601E1 VA: 0x1600E0
	public BattleConst.ShieldEffect ShieldEffect_DHSword; // 0x40
	[SerializeField] // RVA: 0x1600F0 Offset: 0x1601F1 VA: 0x1600F0
	public BattleConst.ShieldEffect ShieldEffect_Spear; // 0x48
	[SerializeField] // RVA: 0x160100 Offset: 0x160201 VA: 0x160100
	public BattleConst.ShieldEffect ShieldEffect_Axe; // 0x50
	[SerializeField] // RVA: 0x160110 Offset: 0x160211 VA: 0x160110
	public BattleConst.ShieldEffect ShieldEffect_Hammer; // 0x58
	[SerializeField] // RVA: 0x160120 Offset: 0x160221 VA: 0x160120
	public BattleConst.ShieldEffect ShieldEffect_TwinSword; // 0x60
	[SerializeField] // RVA: 0x160130 Offset: 0x160231 VA: 0x160130
	public BattleConst.ShieldEffect ShieldEffect_Fist; // 0x68
	[SerializeField] // RVA: 0x160140 Offset: 0x160241 VA: 0x160140
	public BattleConst.ShieldEffect ShieldEffect_Wand; // 0x70
	[SerializeField] // RVA: 0x160150 Offset: 0x160251 VA: 0x160150
	public BattleConst.ShieldEffect ShieldEffect_Farm_Tool; // 0x78
	[SerializeField] // RVA: 0x160160 Offset: 0x160261 VA: 0x160160
	public float BaseKnockback_Length; // 0x80
	[SerializeField] // RVA: 0x160170 Offset: 0x160271 VA: 0x160170
	public float BaseKnockback_Time; // 0x84
	[SerializeField] // RVA: 0x160180 Offset: 0x160281 VA: 0x160180
	public float BaseKnockback_Time_ForPlayer; // 0x88
	[SerializeField] // RVA: 0x160190 Offset: 0x160291 VA: 0x160190
	public float KnockbackMax; // 0x8C
	[SerializeField] // RVA: 0x1601A0 Offset: 0x1602A1 VA: 0x1601A0
	public float CauserKnockbackPower; // 0x90
	[SerializeField] // RVA: 0x1601B0 Offset: 0x1602B1 VA: 0x1601B0
	public float BlowCountMax; // 0x94
	[SerializeField] // RVA: 0x1601C0 Offset: 0x1602C1 VA: 0x1601C0
	public float BaseBlowPower; // 0x98
	[SerializeField] // RVA: 0x1601D0 Offset: 0x1602D1 VA: 0x1601D0
	public float BlowHealSec; // 0x9C
	[SerializeField] // RVA: 0x1601E0 Offset: 0x1602E1 VA: 0x1601E0
	public float BlowHealCoolTime; // 0xA0
	[SerializeField] // RVA: 0x1601F0 Offset: 0x1602F1 VA: 0x1601F0
	public float HitBackPower; // 0xA4
	[SerializeField] // RVA: 0x160200 Offset: 0x160301 VA: 0x160200
	public float KnockBackRateMax; // 0xA8
	[SerializeField] // RVA: 0x160210 Offset: 0x160311 VA: 0x160210
	public float CauserKnockBackRateMax; // 0xAC
	[SerializeField] // RVA: 0x160220 Offset: 0x160321 VA: 0x160220
	public int BlowPower_Sword; // 0xB0
	[SerializeField] // RVA: 0x160230 Offset: 0x160331 VA: 0x160230
	public int BlowPower_DHSword; // 0xB4
	[SerializeField] // RVA: 0x160240 Offset: 0x160341 VA: 0x160240
	public int BlowPower_Axe; // 0xB8
	[SerializeField] // RVA: 0x160250 Offset: 0x160351 VA: 0x160250
	public int BlowPower_Hammer; // 0xBC
	[SerializeField] // RVA: 0x160260 Offset: 0x160361 VA: 0x160260
	public int BlowPower_Wand; // 0xC0
	[SerializeField] // RVA: 0x160270 Offset: 0x160371 VA: 0x160270
	public int BlowPower_Fist; // 0xC4
	[SerializeField] // RVA: 0x160280 Offset: 0x160381 VA: 0x160280
	public int BlowPower_TwinSword; // 0xC8
	[SerializeField] // RVA: 0x160290 Offset: 0x160391 VA: 0x160290
	public int BlowPower_Spear; // 0xCC
	[SerializeField] // RVA: 0x1602A0 Offset: 0x1603A1 VA: 0x1602A0
	public int BlowPower_Farm_Tool; // 0xD0
	[SerializeField] // RVA: 0x1602B0 Offset: 0x1603B1 VA: 0x1602B0
	public float HandCuffs_Distance; // 0xD4
	[SerializeField] // RVA: 0x1602C0 Offset: 0x1603C1 VA: 0x1602C0
	public float HandCuffs_FullChargeTime; // 0xD8
	[SerializeField] // RVA: 0x1602D0 Offset: 0x1603D1 VA: 0x1602D0
	public float HandCuffs_CT_Normal; // 0xDC
	[SerializeField] // RVA: 0x1602E0 Offset: 0x1603E1 VA: 0x1602E0
	public float HandCuffs_CT_Charge; // 0xE0
	[SerializeField] // RVA: 0x1602F0 Offset: 0x1603F1 VA: 0x1602F0
	public float HandCuffs_CT_SkillLevelBias; // 0xE4
	[SerializeField] // RVA: 0x160300 Offset: 0x160401 VA: 0x160300
	public float HandCuffs_CT_Normal_MinTime; // 0xE8
	[SerializeField] // RVA: 0x160310 Offset: 0x160411 VA: 0x160310
	public float HandCuffs_LP; // 0xEC
	[SerializeField] // RVA: 0x160320 Offset: 0x160421 VA: 0x160320
	public float HandCuffs_LP_Max; // 0xF0
	[SerializeField] // RVA: 0x160330 Offset: 0x160431 VA: 0x160330
	public float HandCuffs_LP_SkillLevelBias; // 0xF4
	[SerializeField] // RVA: 0x160340 Offset: 0x160441 VA: 0x160340
	public float HandCuffs_LT; // 0xF8
	[SerializeField] // RVA: 0x160350 Offset: 0x160451 VA: 0x160350
	public float HandCuffs_LT_SkillLevelBias; // 0xFC
	[SerializeField] // RVA: 0x160360 Offset: 0x160461 VA: 0x160360
	public float HandCuffs_CP_Lv_Upper; // 0x100
	[SerializeField] // RVA: 0x160370 Offset: 0x160471 VA: 0x160370
	public float HandCuffs_CP_SkillLevelBias; // 0x104
	[SerializeField] // RVA: 0x160380 Offset: 0x160481 VA: 0x160380
	public float HandCuffs_HealSpeed; // 0x108
	[SerializeField] // RVA: 0x160390 Offset: 0x160491 VA: 0x160390
	public float HandCuffs_CP_EnemyHP; // 0x10C
	[SerializeField] // RVA: 0x1603A0 Offset: 0x1604A1 VA: 0x1603A0
	public float HandCuffs_ItemCP_Radius; // 0x110
	[SerializeField] // RVA: 0x1603B0 Offset: 0x1604B1 VA: 0x1603B0
	public float OutSidePartyMonsterExpRate; // 0x114
	[SerializeField] // RVA: 0x1603C0 Offset: 0x1604C1 VA: 0x1603C0
	public int PoliceBatch_RookieHP; // 0x118
	[SerializeField] // RVA: 0x1603D0 Offset: 0x1604D1 VA: 0x1603D0
	public float AvoidInvincibleDuration; // 0x11C
	[SerializeField] // RVA: 0x1603E0 Offset: 0x1604E1 VA: 0x1603E0
	public int ChargeAttack_Unlock_Level; // 0x120
	[SerializeField] // RVA: 0x1603F0 Offset: 0x1604F1 VA: 0x1603F0
	public int EnemyTargetDamageAction_DecreaseAttackSelectPercent; // 0x124
	[SerializeField] // RVA: 0x160400 Offset: 0x160501 VA: 0x160400
	public int WantedStarLevelOne_CC_MonsterHP; // 0x128
	[SerializeField] // RVA: 0x160410 Offset: 0x160511 VA: 0x160410
	public int WantedStarLevelTwo_CC_MonsterHP; // 0x12C
	[SerializeField] // RVA: 0x160420 Offset: 0x160521 VA: 0x160420
	public int WantedStarLevelThree_CC_MonsterHP; // 0x130
	[SerializeField] // RVA: 0x160430 Offset: 0x160531 VA: 0x160430
	public int WantedStarLevelFour_CC_MonsterHP; // 0x134
	[SerializeField] // RVA: 0x160440 Offset: 0x160541 VA: 0x160440
	public int WantedStarLevelFive_CC_MonsterHP; // 0x138
	[SerializeField] // RVA: 0x160450 Offset: 0x160551 VA: 0x160450
	public int AutoRPHeal_Amount; // 0x13C
	[SerializeField] // RVA: 0x160460 Offset: 0x160561 VA: 0x160460
	public float AutoRPHeal_Interval; // 0x140
	public float AutoRPHeal_StartTime; // 0x144
	[SerializeField] // RVA: 0x160470 Offset: 0x160571 VA: 0x160470
	public float DeadWaitTime; // 0x148
	public float InvincibleTime_Getup; // 0x14C
	[SerializeField] // RVA: 0x160480 Offset: 0x160581 VA: 0x160480
	public int FocusEnemyNameColorRed_LevelDiff; // 0x150
	[SerializeField] // RVA: 0x160490 Offset: 0x160591 VA: 0x160490
	public int FocusEnemyNameColorOrange_LevelDiff; // 0x154
	[SerializeField] // RVA: 0x1604A0 Offset: 0x1605A1 VA: 0x1604A0
	public int WaterPotAmount_01; // 0x158
	[SerializeField] // RVA: 0x1604B0 Offset: 0x1605B1 VA: 0x1604B0
	public int WaterPotAmount_02; // 0x15C
	[SerializeField] // RVA: 0x1604C0 Offset: 0x1605C1 VA: 0x1604C0
	public int WaterPotAmount_03; // 0x160
	[SerializeField] // RVA: 0x1604D0 Offset: 0x1605D1 VA: 0x1604D0
	public int WaterPotAmount_04; // 0x164
	[SerializeField] // RVA: 0x1604E0 Offset: 0x1605E1 VA: 0x1604E0
	public int WaterPotAmount_05; // 0x168
	[SerializeField] // RVA: 0x1604F0 Offset: 0x1605F1 VA: 0x1604F0
	public float YKillHeight; // 0x16C
	[SerializeField] // RVA: 0x160500 Offset: 0x160601 VA: 0x160500
	public float DualSkill_ApplyDamage; // 0x170
	[SerializeField] // RVA: 0x160510 Offset: 0x160611 VA: 0x160510
	public float DualSkill_TakeDamage; // 0x174
	[SerializeField] // RVA: 0x160520 Offset: 0x160621 VA: 0x160520
	public float DualSkill_TakeHeal; // 0x178
	[SerializeField] // RVA: 0x160530 Offset: 0x160631 VA: 0x160530
	public float DualSkill_UseRA; // 0x17C
	[SerializeField] // RVA: 0x160540 Offset: 0x160641 VA: 0x160540
	public float DualSkill_UseMagic; // 0x180
	[SerializeField] // RVA: 0x160550 Offset: 0x160651 VA: 0x160550
	public float DualSkill_DestroyEnemy; // 0x184
	[SerializeField] // RVA: 0x160560 Offset: 0x160661 VA: 0x160560
	public float DualSkill_PlayerRate; // 0x188
	[SerializeField] // RVA: 0x160570 Offset: 0x160671 VA: 0x160570
	public float DualSkill_BadgeRate; // 0x18C
	[SerializeField] // RVA: 0x160580 Offset: 0x160681 VA: 0x160580
	public float DualSkill_Attack; // 0x190
	[SerializeField] // RVA: 0x160590 Offset: 0x160691 VA: 0x160590
	public float TrowDamage_Base; // 0x194
	[SerializeField] // RVA: 0x1605A0 Offset: 0x1606A1 VA: 0x1605A0
	public float TrowDamageRate_Lv200; // 0x198
	[SerializeField] // RVA: 0x1605B0 Offset: 0x1606B1 VA: 0x1605B0
	public float TrowDamageRate_Lv100; // 0x19C
	[SerializeField] // RVA: 0x1605C0 Offset: 0x1606C1 VA: 0x1605C0
	public float TrowDamageRate_Lv80; // 0x1A0
	[SerializeField] // RVA: 0x1605D0 Offset: 0x1606D1 VA: 0x1605D0
	public float TrowDamageRate_Lv60; // 0x1A4
	[SerializeField] // RVA: 0x1605E0 Offset: 0x1606E1 VA: 0x1605E0
	public float TrowDamageRate_Lv40; // 0x1A8
	[SerializeField] // RVA: 0x1605F0 Offset: 0x1606F1 VA: 0x1605F0
	public float TrowDamageRate_Lv20; // 0x1AC
	[SerializeField] // RVA: 0x160600 Offset: 0x160701 VA: 0x160600
	public float LockonRange_Player; // 0x1B0
	[SerializeField] // RVA: 0x160610 Offset: 0x160711 VA: 0x160610
	public float LockonAngle_Player; // 0x1B4
	[SerializeField] // RVA: 0x160620 Offset: 0x160721 VA: 0x160620
	public float LockonRange_Other; // 0x1B8
	[SerializeField] // RVA: 0x160630 Offset: 0x160731 VA: 0x160630
	public float LockonAngle_Other; // 0x1BC
	[SerializeField] // RVA: 0x160640 Offset: 0x160741 VA: 0x160640
	public float AutoLockonRange; // 0x1C0
	[SerializeField] // RVA: 0x160650 Offset: 0x160751 VA: 0x160650
	public float AutoLockonAngle; // 0x1C4
	[SerializeField] // RVA: 0x160660 Offset: 0x160761 VA: 0x160660
	public float FootSteps_Human_SoundDistanceMax; // 0x1C8
	[SerializeField] // RVA: 0x160670 Offset: 0x160771 VA: 0x160670
	public float FootSteps_Human_SoundDistanceMin; // 0x1CC
	[SerializeField] // RVA: 0x160680 Offset: 0x160781 VA: 0x160680
	public float FootSteps_Human_EffectDistance; // 0x1D0
	[SerializeField] // RVA: 0x160690 Offset: 0x160791 VA: 0x160690
	public float FootSteps_Small_SoundDistanceMax; // 0x1D4
	[SerializeField] // RVA: 0x1606A0 Offset: 0x1607A1 VA: 0x1606A0
	public float FootSteps_Small_SoundDistanceMin; // 0x1D8
	[SerializeField] // RVA: 0x1606B0 Offset: 0x1607B1 VA: 0x1606B0
	public float FootSteps_Small_EffectDistance; // 0x1DC
	[SerializeField] // RVA: 0x1606C0 Offset: 0x1607C1 VA: 0x1606C0
	public float FootSteps_Medium_SoundDistanceMax; // 0x1E0
	[SerializeField] // RVA: 0x1606D0 Offset: 0x1607D1 VA: 0x1606D0
	public float FootSteps_Medium_SoundDistanceMin; // 0x1E4
	[SerializeField] // RVA: 0x1606E0 Offset: 0x1607E1 VA: 0x1606E0
	public float FootSteps_Medium_EffectDistance; // 0x1E8
	[SerializeField] // RVA: 0x1606F0 Offset: 0x1607F1 VA: 0x1606F0
	public float FootSteps_Large_SoundDistanceMax; // 0x1EC
	[SerializeField] // RVA: 0x160700 Offset: 0x160801 VA: 0x160700
	public float FootSteps_Large_SoundDistanceMin; // 0x1F0
	[SerializeField] // RVA: 0x160710 Offset: 0x160811 VA: 0x160710
	public float FootSteps_Large_EffectDistance; // 0x1F4
	[SerializeField] // RVA: 0x160720 Offset: 0x160821 VA: 0x160720
	public float FootSteps_SoundPlayMax; // 0x1F8
	[SerializeField] // RVA: 0x160730 Offset: 0x160831 VA: 0x160730
	public float FootSteps_SoundPlayObservePeriod; // 0x1FC
	[SerializeField] // RVA: 0x160740 Offset: 0x160841 VA: 0x160740
	public float FootSteps_SoundVolumeMax; // 0x200
	[SerializeField] // RVA: 0x160750 Offset: 0x160851 VA: 0x160750
	public float FootSteps_SoundVolumeMin; // 0x204
	[SerializeField] // RVA: 0x160760 Offset: 0x160861 VA: 0x160760
	public float FootSteps_SoundPitchRange; // 0x208
	[SerializeField] // RVA: 0x160770 Offset: 0x160871 VA: 0x160770
	public float GrappleBuster_ImpactSize_S; // 0x20C
	[SerializeField] // RVA: 0x160780 Offset: 0x160881 VA: 0x160780
	public float GrappleBuster_ImpactSize_M; // 0x210
	[SerializeField] // RVA: 0x160790 Offset: 0x160891 VA: 0x160790
	public float GrappleBuster_ImpactSize_L; // 0x214
	[SerializeField] // RVA: 0x1607A0 Offset: 0x1608A1 VA: 0x1607A0
	public int WalkSkillCount; // 0x218
	[SerializeField] // RVA: 0x1607B0 Offset: 0x1608B1 VA: 0x1607B0
	public float PoisonInterval; // 0x21C
	[SerializeField] // RVA: 0x1607C0 Offset: 0x1608C1 VA: 0x1607C0
	public float SickInterval; // 0x220
	[SerializeField] // RVA: 0x1607D0 Offset: 0x1608D1 VA: 0x1607D0
	public float SickDamage; // 0x224
	[SerializeField] // RVA: 0x1607E0 Offset: 0x1608E1 VA: 0x1607E0
	public float StunTime; // 0x228
	[SerializeField] // RVA: 0x1607F0 Offset: 0x1608F1 VA: 0x1607F0
	public float SleepTime; // 0x22C
	[SerializeField] // RVA: 0x160800 Offset: 0x160901 VA: 0x160800
	public float Influence_AttakSkill; // 0x230
	[SerializeField] // RVA: 0x160810 Offset: 0x160911 VA: 0x160810
	public float Influence_AttributeSkill; // 0x234
	[SerializeField] // RVA: 0x160820 Offset: 0x160921 VA: 0x160820
	public float Influence_LeaderSkill; // 0x238
	[SerializeField] // RVA: 0x160830 Offset: 0x160931 VA: 0x160830
	public float Influence_MonsterSkill; // 0x23C
	[SerializeField] // RVA: 0x160840 Offset: 0x160941 VA: 0x160840
	public float SeedSupport_CoolTime; // 0x240
	[SerializeField] // RVA: 0x160850 Offset: 0x160951 VA: 0x160850
	public float SeedSupport_Countdown; // 0x244
	[SerializeField] // RVA: 0x160860 Offset: 0x160961 VA: 0x160860
	public float EquipSubAttribute_Sneaking_Param; // 0x248
	[SerializeField] // RVA: 0x160870 Offset: 0x160971 VA: 0x160870
	public float EquipSubAttribute_DashUp_Param; // 0x24C
	[SerializeField] // RVA: 0x160880 Offset: 0x160981 VA: 0x160880
	public float EquipSubAttribute_MaxDash_Param; // 0x250
	[SerializeField] // RVA: 0x160890 Offset: 0x160991 VA: 0x160890
	public float EquipSubAttribute_SpeedDown_Param; // 0x254
	[SerializeField] // RVA: 0x1608A0 Offset: 0x1609A1 VA: 0x1608A0
	public float EquipSubAttribute_Rolling_Param; // 0x258
	[SerializeField] // RVA: 0x1608B0 Offset: 0x1609B1 VA: 0x1608B0
	public float EquipSubAttribute_Annette_Param1; // 0x25C
	[SerializeField] // RVA: 0x1608C0 Offset: 0x1609C1 VA: 0x1608C0
	public float EquipSubAttribute_Annette_Param2; // 0x260
	[SerializeField] // RVA: 0x1608D0 Offset: 0x1609D1 VA: 0x1608D0
	public SoundID EquipSubAttribute_SeChange1_SoundID; // 0x264
	[SerializeField] // RVA: 0x1608E0 Offset: 0x1609E1 VA: 0x1608E0
	public SoundID EquipSubAttribute_SeChange2_SoundID; // 0x268
	[SerializeField] // RVA: 0x1608F0 Offset: 0x1609F1 VA: 0x1608F0
	public float EquipSubAttribute_KnockbackDef_Param; // 0x26C
	[SerializeField] // RVA: 0x160900 Offset: 0x160A01 VA: 0x160900
	public float EquipSubAttribute_HatakePlow_SpeedParam; // 0x270
	[SerializeField] // RVA: 0x160910 Offset: 0x160A11 VA: 0x160910
	public float EquipSubAttribute_BfrAtc_Param; // 0x274
	[SerializeField] // RVA: 0x160920 Offset: 0x160A21 VA: 0x160920
	public float EquipSubAttribute_GstAtc_Param; // 0x278
	[SerializeField] // RVA: 0x160930 Offset: 0x160A31 VA: 0x160930
	public float EquipSubAttribute_AtkLength_Param1; // 0x27C
	[SerializeField] // RVA: 0x160940 Offset: 0x160A41 VA: 0x160940
	public float EquipSubAttribute_AtkLength_PosMin; // 0x280
	[SerializeField] // RVA: 0x160950 Offset: 0x160A51 VA: 0x160950
	public float EquipSubAttribute_AtkLength_PosMax; // 0x284
	[SerializeField] // RVA: 0x160960 Offset: 0x160A61 VA: 0x160960
	public float EquipSubAttribute_AtkLength_ScaleMin; // 0x288
	[SerializeField] // RVA: 0x160970 Offset: 0x160A71 VA: 0x160970
	public float EquipSubAttribute_AtkLength_ScaleMax; // 0x28C
	[SerializeField] // RVA: 0x160980 Offset: 0x160A81 VA: 0x160980
	public float EquipSubAttribute_RpHerf_Param; // 0x290
	[SerializeField] // RVA: 0x160990 Offset: 0x160A91 VA: 0x160990
	public float EquipSubAttribute_RpZero_Param; // 0x294
	[SerializeField] // RVA: 0x1609A0 Offset: 0x160AA1 VA: 0x1609A0
	public float EquipSubAttribute_SkillExp_Param; // 0x298
	[SerializeField] // RVA: 0x1609B0 Offset: 0x160AB1 VA: 0x1609B0
	public float EquipSubAttribute_General_Param1; // 0x29C
	[SerializeField] // RVA: 0x1609C0 Offset: 0x160AC1 VA: 0x1609C0
	public float EquipSubAttribute_General_Param2; // 0x2A0
	[SerializeField] // RVA: 0x1609D0 Offset: 0x160AD1 VA: 0x1609D0
	public int EquipSubAttribute_LuckyDrop1_Param1; // 0x2A4
	[SerializeField] // RVA: 0x1609E0 Offset: 0x160AE1 VA: 0x1609E0
	public int EquipSubAttribute_LuckyDrop1_Param2; // 0x2A8
	[SerializeField] // RVA: 0x1609F0 Offset: 0x160AF1 VA: 0x1609F0
	public int EquipSubAttribute_LuckyDrop2_Param1; // 0x2AC
	[SerializeField] // RVA: 0x160A00 Offset: 0x160B01 VA: 0x160A00
	public int EquipSubAttribute_LuckyDrop2_Param2; // 0x2B0
	[SerializeField] // RVA: 0x160A10 Offset: 0x160B11 VA: 0x160A10
	public int EquipSubAttribute_RareDrop_Param1; // 0x2B4
	[SerializeField] // RVA: 0x160A20 Offset: 0x160B21 VA: 0x160A20
	public int EquipSubAttribute_RareDrop_Param2; // 0x2B8
	[SerializeField] // RVA: 0x160A30 Offset: 0x160B31 VA: 0x160A30
	public float EquipSubAttribute_UpRecovery_Param1; // 0x2BC
	[SerializeField] // RVA: 0x160A40 Offset: 0x160B41 VA: 0x160A40
	public float EquipSubAttribute_UpRecovery_Param2; // 0x2C0
	[SerializeField] // RVA: 0x160A50 Offset: 0x160B51 VA: 0x160A50
	public float EquipSubAttribute_AccPoison; // 0x2C4
	[SerializeField] // RVA: 0x160A60 Offset: 0x160B61 VA: 0x160A60
	public float EquipSubAttribute_AccParalysis; // 0x2C8
	[SerializeField] // RVA: 0x160A70 Offset: 0x160B71 VA: 0x160A70
	public float EquipSubAttribute_AccSeal; // 0x2CC
	[SerializeField] // RVA: 0x160A80 Offset: 0x160B81 VA: 0x160A80
	public float EquipSubAttribute_DefMu; // 0x2D0
	[SerializeField] // RVA: 0x160A90 Offset: 0x160B91 VA: 0x160A90
	public float EquipSubAttribute_HpMaxUp_Param; // 0x2D4
	[SerializeField] // RVA: 0x160AA0 Offset: 0x160BA1 VA: 0x160AA0
	public Pad.VibrationType Vibration_OnDamage; // 0x2D8
	[SerializeField] // RVA: 0x160AB0 Offset: 0x160BB1 VA: 0x160AB0
	public Pad.VibrationType Vibration_OnDamageBlow; // 0x2DC
	[SerializeField] // RVA: 0x160AC0 Offset: 0x160BC1 VA: 0x160AC0
	public Pad.VibrationType Vibration_OnCharged; // 0x2E0
	[SerializeField] // RVA: 0x160AD0 Offset: 0x160BD1 VA: 0x160AD0
	public Pad.VibrationType Vibration_OnHitCritical; // 0x2E4
	[SerializeField] // RVA: 0x160AE0 Offset: 0x160BE1 VA: 0x160AE0
	public Pad.VibrationType Vibration_OnHitRA; // 0x2E8
	[SerializeField] // RVA: 0x160AF0 Offset: 0x160BF1 VA: 0x160AF0
	public Pad.VibrationType Vibration_OnHitDualSkill; // 0x2EC
	[SerializeField] // RVA: 0x160B00 Offset: 0x160C01 VA: 0x160B00
	public float BaseChargeSec; // 0x2F0
	[SerializeField] // RVA: 0x160B10 Offset: 0x160C11 VA: 0x160B10
	public float FarmCamera_Angle; // 0x2F4
	[SerializeField] // RVA: 0x160B20 Offset: 0x160C21 VA: 0x160B20
	public float FarmCamera_Distance; // 0x2F8
	[SerializeField] // RVA: 0x160B30 Offset: 0x160C31 VA: 0x160B30
	public float FarmCamera_FOV; // 0x2FC
	[SerializeField] // RVA: 0x160B40 Offset: 0x160C41 VA: 0x160B40
	public float FarmCamera_RestartTime; // 0x300
	[SerializeField] // RVA: 0x160B50 Offset: 0x160C51 VA: 0x160B50
	public float FarmCamera_StopTime; // 0x304
	[SerializeField] // RVA: 0x160B60 Offset: 0x160C61 VA: 0x160B60
	public float CharacterForward_DotValue; // 0x308
	[SerializeField] // RVA: 0x160B70 Offset: 0x160C71 VA: 0x160B70
	public float BackAttack_DamageRate; // 0x30C
	[SerializeField] // RVA: 0x160B80 Offset: 0x160C81 VA: 0x160B80
	public float BackAttack_UpCritical; // 0x310
	[SerializeField] // RVA: 0x160B90 Offset: 0x160C91 VA: 0x160B90
	public float SurpriseAttack_Critical; // 0x314
	[SerializeField] // RVA: 0x160BA0 Offset: 0x160CA1 VA: 0x160BA0
	public int GateMonster_DecreaseApeearCount_Easy; // 0x318
	[SerializeField] // RVA: 0x160BB0 Offset: 0x160CB1 VA: 0x160BB0
	public float ToolCharge_StartTime; // 0x31C
	[SerializeField] // RVA: 0x160BC0 Offset: 0x160CC1 VA: 0x160BC0
	public float AvoidCoolTime; // 0x320
	[SerializeField] // RVA: 0x160BD0 Offset: 0x160CD1 VA: 0x160BD0
	public int MaxLevel; // 0x324
	[SerializeField] // RVA: 0x160BE0 Offset: 0x160CE1 VA: 0x160BE0
	public int HPDrainMin; // 0x328
	[SerializeField] // RVA: 0x160BF0 Offset: 0x160CF1 VA: 0x160BF0
	public int HPDrainMax; // 0x32C
	[SerializeField] // RVA: 0x160C00 Offset: 0x160D01 VA: 0x160C00
	public int DamageMin; // 0x330
	[SerializeField] // RVA: 0x160C10 Offset: 0x160D11 VA: 0x160C10
	public int DamageMax; // 0x334
	[SerializeField] // RVA: 0x160C20 Offset: 0x160D21 VA: 0x160C20
	public int CriticalRateMax; // 0x338
	[SerializeField] // RVA: 0x160C30 Offset: 0x160D31 VA: 0x160C30
	public int Param_Max_HP; // 0x33C
	[SerializeField] // RVA: 0x160C40 Offset: 0x160D41 VA: 0x160C40
	public int Param_Max_RP; // 0x340
	[SerializeField] // RVA: 0x160C50 Offset: 0x160D51 VA: 0x160C50
	public int Param_Min; // 0x344
	[SerializeField] // RVA: 0x160C60 Offset: 0x160D61 VA: 0x160C60
	public int Param_Max; // 0x348
	[SerializeField] // RVA: 0x160C70 Offset: 0x160D71 VA: 0x160C70
	public float Param_Percent_Min; // 0x34C
	[SerializeField] // RVA: 0x160C80 Offset: 0x160D81 VA: 0x160C80
	public float Param_Percent_Max; // 0x350
	[SerializeField] // RVA: 0x160C90 Offset: 0x160D91 VA: 0x160C90
	public float Param_Attribute_Percent_Min; // 0x354
	[SerializeField] // RVA: 0x160CA0 Offset: 0x160DA1 VA: 0x160CA0
	public float Param_Attribute_Percent_Max; // 0x358
	[SerializeField] // RVA: 0x160CB0 Offset: 0x160DB1 VA: 0x160CB0
	public float Param_ChargeSpeed_Percent_Min; // 0x35C
	[SerializeField] // RVA: 0x160CC0 Offset: 0x160DC1 VA: 0x160CC0
	public float Param_ChargeSpeed_Percent_Max; // 0x360
	[SerializeField] // RVA: 0x160CD0 Offset: 0x160DD1 VA: 0x160CD0
	public float Param_Percent_Over_Max; // 0x364
	[SerializeField] // RVA: 0x160CE0 Offset: 0x160DE1 VA: 0x160CE0
	public int ZakoExp_Max; // 0x368
	[SerializeField] // RVA: 0x160CF0 Offset: 0x160DF1 VA: 0x160CF0
	public int ZakoExp_Boss; // 0x36C
	[SerializeField] // RVA: 0x160D00 Offset: 0x160E01 VA: 0x160D00
	public int Exp_Max; // 0x370
	[SerializeField] // RVA: 0x160D10 Offset: 0x160E11 VA: 0x160D10
	public int Skill_Exp_Max; // 0x374
	[SerializeField] // RVA: 0x160D20 Offset: 0x160E21 VA: 0x160D20
	public int MaxDefeatBonus; // 0x378
	[SerializeField] // RVA: 0x160D30 Offset: 0x160E31 VA: 0x160D30
	public int MaxDefeatBonusALL; // 0x37C
	[SerializeField] // RVA: 0x160D40 Offset: 0x160E41 VA: 0x160D40
	public int SkillLevel_AvoidAttack; // 0x380
	[SerializeField] // RVA: 0x160D50 Offset: 0x160E51 VA: 0x160D50
	public int SkillLevel_ChargeAttack; // 0x384
	[SerializeField] // RVA: 0x160D60 Offset: 0x160E61 VA: 0x160D60
	public int SkillLevel_SP; // 0x388
	[SerializeField] // RVA: 0x160D70 Offset: 0x160E71 VA: 0x160D70
	public int SkillLevel_Max_Party_Def; // 0x38C
	[SerializeField] // RVA: 0x160D80 Offset: 0x160E81 VA: 0x160D80
	public float HealRate_Shinanasa; // 0x390
	[SerializeField] // RVA: 0x160D90 Offset: 0x160E91 VA: 0x160D90
	public float Wand_MagicRPCost; // 0x394
	[SerializeField] // RVA: 0x160DA0 Offset: 0x160EA1 VA: 0x160DA0
	public float NpcSpringBone_AwakeDistance; // 0x398
	[SerializeField] // RVA: 0x160DB0 Offset: 0x160EB1 VA: 0x160DB0
	public float NpcSpringBone_AwakeDot; // 0x39C
	[SerializeField] // RVA: 0x160DC0 Offset: 0x160EC1 VA: 0x160DC0
	public float NpcSpringBone_AwakeRange; // 0x3A0
	[SerializeField] // RVA: 0x160DD0 Offset: 0x160ED1 VA: 0x160DD0
	public float NpcSpringBone_SleepTime; // 0x3A4
	private static BattleConst _Instance; // 0x0

	// Properties
	public static BattleConst Instance { get; }

	// Methods

	// RVA: 0x20D5140 Offset: 0x20D5241 VA: 0x20D5140
	public BattleConst.ShieldEffect GetShieldEffectByItemCategory(ItemCategory itemCategory) { }

	// RVA: 0x20D51D0 Offset: 0x20D52D1 VA: 0x20D51D0
	public int GetCanCatchWantedMonsterHPByStarLevel(int starLevel) { }

	// RVA: 0x20D5230 Offset: 0x20D5331 VA: 0x20D5230
	public static BattleConst get_Instance() { }

	// RVA: 0x20D5340 Offset: 0x20D5441 VA: 0x20D5340
	public void .ctor() { }
}

