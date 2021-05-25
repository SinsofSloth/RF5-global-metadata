[Serializable]
public struct MonsterDataTable // TypeDefIndex: 7772
{
	// Fields
	[SerializeField] // RVA: 0x169510 Offset: 0x169611 VA: 0x169510
	public MonsterDataID DataID; // 0x0
	[SerializeField] // RVA: 0x169520 Offset: 0x169621 VA: 0x169520
	public MonsterID MonsterId; // 0x4
	[SerializeField] // RVA: 0x169530 Offset: 0x169631 VA: 0x169530
	public MonsterModelDataID ModelDataID; // 0x8
	[SerializeField] // RVA: 0x169540 Offset: 0x169641 VA: 0x169540
	public FootStepType FootStepType; // 0xC
	[SerializeField] // RVA: 0x169550 Offset: 0x169651 VA: 0x169550
	public MonsterFootStepEventDataID MonsterFootStepEventDataID; // 0x10
	[SerializeField] // RVA: 0x169560 Offset: 0x169661 VA: 0x169560
	public MonsterCharacterType CharacterType; // 0x14
	[SerializeField] // RVA: 0x169570 Offset: 0x169671 VA: 0x169570
	public MoveParamID MoveParamID; // 0x18
	[SerializeField] // RVA: 0x169580 Offset: 0x169681 VA: 0x169580
	public MoveParamID FriendMoveParamID; // 0x1C
	[SerializeField] // RVA: 0x169590 Offset: 0x169691 VA: 0x169590
	public float RideMaxSpeedRate; // 0x20
	[SerializeField] // RVA: 0x1695A0 Offset: 0x1696A1 VA: 0x1695A0
	public int RideCount; // 0x24
	[SerializeField] // RVA: 0x1695B0 Offset: 0x1696B1 VA: 0x1695B0
	public MonsterRideAnimationType RideAnimationType; // 0x28
	[SerializeField] // RVA: 0x1695C0 Offset: 0x1696C1 VA: 0x1695C0
	public float RideCameraYOffset; // 0x2C
	[SerializeField] // RVA: 0x1695D0 Offset: 0x1696D1 VA: 0x1695D0
	public float RideCameraDistanceOffset; // 0x30
	[SerializeField] // RVA: 0x1695E0 Offset: 0x1696E1 VA: 0x1695E0
	public int DefeatBonus_HP; // 0x34
	[SerializeField] // RVA: 0x1695F0 Offset: 0x1696F1 VA: 0x1695F0
	public int DefeatBonus_STR; // 0x38
	[SerializeField] // RVA: 0x169600 Offset: 0x169701 VA: 0x169600
	public int DefeatBonus_INT; // 0x3C
	[SerializeField] // RVA: 0x169610 Offset: 0x169711 VA: 0x169610
	public int DefeatBonus_VIT; // 0x40
	[SerializeField] // RVA: 0x169620 Offset: 0x169721 VA: 0x169620
	public bool CanFriend; // 0x44
	[SerializeField] // RVA: 0x169630 Offset: 0x169731 VA: 0x169630
	public int CanFriendInitPercent; // 0x48
	[SerializeField] // RVA: 0x169640 Offset: 0x169741 VA: 0x169640
	public float FriendMovementOrderCloseRange; // 0x4C
	[SerializeField] // RVA: 0x169650 Offset: 0x169751 VA: 0x169650
	public float FriendMovementOrderLeaveRange; // 0x50
	[SerializeField] // RVA: 0x169660 Offset: 0x169761 VA: 0x169660
	public float FriendBehaviorWaitRate; // 0x54
	[SerializeField] // RVA: 0x169670 Offset: 0x169771 VA: 0x169670
	public float EnemyBehaviorWaitRate_Easy; // 0x58
	[SerializeField] // RVA: 0x169680 Offset: 0x169781 VA: 0x169680
	public float EnemyBehaviorWaitRate_Normal; // 0x5C
	[SerializeField] // RVA: 0x169690 Offset: 0x169791 VA: 0x169690
	public int DefenceRestraint; // 0x60
	[SerializeField] // RVA: 0x1696A0 Offset: 0x1697A1 VA: 0x1696A0
	public int ReleaseRestraintRate; // 0x64
	[SerializeField] // RVA: 0x1696B0 Offset: 0x1697B1 VA: 0x1696B0
	public int HandcuffsEffectSize; // 0x68
	[SerializeField] // RVA: 0x1696C0 Offset: 0x1697C1 VA: 0x1696C0
	public float HandcuffsEffectOffsetY; // 0x6C
	[SerializeField] // RVA: 0x1696D0 Offset: 0x1697D1 VA: 0x1696D0
	public bool CanCatch; // 0x70
	[SerializeField] // RVA: 0x1696E0 Offset: 0x1697E1 VA: 0x1696E0
	public int CanCatchInitPercent; // 0x74
	[SerializeField] // RVA: 0x1696F0 Offset: 0x1697F1 VA: 0x1696F0
	public float GrappleRotationY; // 0x78
	[SerializeField] // RVA: 0x169700 Offset: 0x169801 VA: 0x169700
	public Vector3 GrappleHorizontalOffset; // 0x7C
	[SerializeField] // RVA: 0x169710 Offset: 0x169811 VA: 0x169710
	public Vector3 GrappleVerticalOffset; // 0x88
	[SerializeField] // RVA: 0x169720 Offset: 0x169821 VA: 0x169720
	public MonsterFavoriteItemData FavoriteItemData; // 0x98
	[SerializeField] // RVA: 0x169730 Offset: 0x169831 VA: 0x169730
	public int YieldPercent; // 0xA0
	[SerializeField] // RVA: 0x169740 Offset: 0x169841 VA: 0x169740
	public ItemID[] YieldItemIDArray; // 0xA8
	[SerializeField] // RVA: 0x169750 Offset: 0x169851 VA: 0x169750
	public MonsterBehaviorDataID BehaviorDataID; // 0xB0
	[SerializeField] // RVA: 0x169760 Offset: 0x169861 VA: 0x169760
	public MonsterDropItemDataID DropItemDataID; // 0xB4
	[SerializeField] // RVA: 0x169770 Offset: 0x169871 VA: 0x169770
	public Master BossDataAssetID; // 0xB8
	[SerializeField] // RVA: 0x169780 Offset: 0x169881 VA: 0x169780
	public bool BossColorVariation; // 0xBC
	[SerializeField] // RVA: 0x169790 Offset: 0x169891 VA: 0x169790
	public CharaParamDataTable CharaParam; // 0xC0
	private static MonsterDataTableArray _MonsterDataTableArray; // 0x0

	// Methods

	// RVA: 0x2170DC0 Offset: 0x2170EC1 VA: 0x2170DC0
	public static MonsterDataTable GetDataTable(MonsterDataID monsterDataID) { }

	// RVA: 0x2170F50 Offset: 0x2171051 VA: 0x2170F50
	public static MonsterDataTable GetDataTable(int index) { }
}

