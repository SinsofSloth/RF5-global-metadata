[MessagePackObjectAttribute] // RVA: 0x146260 Offset: 0x146361 VA: 0x146260
[Serializable]
public class EventUnlockFlagData // TypeDefIndex: 7179
{
	// Fields
	[KeyAttribute] // RVA: 0x164650 Offset: 0x164751 VA: 0x164650
	[SerializeField] // RVA: 0x164650 Offset: 0x164751 VA: 0x164650
	public EventScriptID ScriptId; // 0x10
	[KeyAttribute] // RVA: 0x1646A0 Offset: 0x1647A1 VA: 0x1646A0
	[SerializeField] // RVA: 0x1646A0 Offset: 0x1647A1 VA: 0x1646A0
	public EventPointID EventPointId; // 0x14
	[KeyAttribute] // RVA: 0x1646F0 Offset: 0x1647F1 VA: 0x1646F0
	[SerializeField] // RVA: 0x1646F0 Offset: 0x1647F1 VA: 0x1646F0
	public EventCheckType eventCheckType; // 0x18
	[KeyAttribute] // RVA: 0x164740 Offset: 0x164841 VA: 0x164740
	[SerializeField] // RVA: 0x164740 Offset: 0x164841 VA: 0x164740
	public long EventStartDay; // 0x20
	[KeyAttribute] // RVA: 0x164790 Offset: 0x164891 VA: 0x164790
	[SerializeField] // RVA: 0x164790 Offset: 0x164891 VA: 0x164790
	public int EventStartTime; // 0x28
	[KeyAttribute] // RVA: 0x1647E0 Offset: 0x1648E1 VA: 0x1647E0
	[SerializeField] // RVA: 0x1647E0 Offset: 0x1648E1 VA: 0x1647E0
	public int EventEndTime; // 0x2C
	[KeyAttribute] // RVA: 0x164830 Offset: 0x164931 VA: 0x164830
	[SerializeField] // RVA: 0x164830 Offset: 0x164931 VA: 0x164830
	public IconType IconType; // 0x30
	[KeyAttribute] // RVA: 0x164880 Offset: 0x164981 VA: 0x164880
	[SerializeField] // RVA: 0x164880 Offset: 0x164981 VA: 0x164880
	public IconViewType IconViewType; // 0x34
	[KeyAttribute] // RVA: 0x1648D0 Offset: 0x1649D1 VA: 0x1648D0
	[SerializeField] // RVA: 0x1648D0 Offset: 0x1649D1 VA: 0x1648D0
	public GameFlagData PointOnFlag; // 0x38
	[KeyAttribute] // RVA: 0x164920 Offset: 0x164A21 VA: 0x164920
	[SerializeField] // RVA: 0x164920 Offset: 0x164A21 VA: 0x164920
	public GameFlagData StoryFlag; // 0x3C
	[KeyAttribute] // RVA: 0x164970 Offset: 0x164A71 VA: 0x164970
	[SerializeField] // RVA: 0x164970 Offset: 0x164A71 VA: 0x164970
	public GameFlagData DeleteEventPointFlag; // 0x40
	[KeyAttribute] // RVA: 0x1649C0 Offset: 0x164AC1 VA: 0x1649C0
	[SerializeField] // RVA: 0x1649C0 Offset: 0x164AC1 VA: 0x1649C0
	public GameFlagData[] On; // 0x48
	[KeyAttribute] // RVA: 0x164A10 Offset: 0x164B11 VA: 0x164A10
	[SerializeField] // RVA: 0x164A10 Offset: 0x164B11 VA: 0x164A10
	public GameFlagData[] Off; // 0x50
	[KeyAttribute] // RVA: 0x164A60 Offset: 0x164B61 VA: 0x164A60
	[SerializeField] // RVA: 0x164A60 Offset: 0x164B61 VA: 0x164A60
	public GameFlagData[] NpcOn; // 0x58
	[KeyAttribute] // RVA: 0x164AB0 Offset: 0x164BB1 VA: 0x164AB0
	[SerializeField] // RVA: 0x164AB0 Offset: 0x164BB1 VA: 0x164AB0
	public GameFlagData[] NpcOff; // 0x60
	[KeyAttribute] // RVA: 0x164B00 Offset: 0x164C01 VA: 0x164B00
	[SerializeField] // RVA: 0x164B00 Offset: 0x164C01 VA: 0x164B00
	public GameFlagData[] FlagOn; // 0x68
	[KeyAttribute] // RVA: 0x164B50 Offset: 0x164C51 VA: 0x164B50
	[SerializeField] // RVA: 0x164B50 Offset: 0x164C51 VA: 0x164B50
	public GameFlagData[] FlagOff; // 0x70
	[KeyAttribute] // RVA: 0x164BA0 Offset: 0x164CA1 VA: 0x164BA0
	[SerializeField] // RVA: 0x164BA0 Offset: 0x164CA1 VA: 0x164BA0
	public bool PointActive; // 0x78
	[KeyAttribute] // RVA: 0x164BF0 Offset: 0x164CF1 VA: 0x164BF0
	[SerializeField] // RVA: 0x164BF0 Offset: 0x164CF1 VA: 0x164BF0
	public FieldSceneId SceneId; // 0x7C
	[KeyAttribute] // RVA: 0x164C40 Offset: 0x164D41 VA: 0x164C40
	[SerializeField] // RVA: 0x164C40 Offset: 0x164D41 VA: 0x164C40
	public float PosX; // 0x80
	[KeyAttribute] // RVA: 0x164C90 Offset: 0x164D91 VA: 0x164C90
	[SerializeField] // RVA: 0x164C90 Offset: 0x164D91 VA: 0x164C90
	public float PosY; // 0x84
	[KeyAttribute] // RVA: 0x164CE0 Offset: 0x164DE1 VA: 0x164CE0
	[SerializeField] // RVA: 0x164CE0 Offset: 0x164DE1 VA: 0x164CE0
	public float PosZ; // 0x88

	// Methods

	// RVA: 0x2079ED0 Offset: 0x2079FD1 VA: 0x2079ED0
	public EventUnlockFlagData Clone() { }

	// RVA: 0x2079F60 Offset: 0x207A061 VA: 0x2079F60
	public void .ctor() { }
}

