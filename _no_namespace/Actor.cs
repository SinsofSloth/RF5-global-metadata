[DefaultMemberAttribute] // RVA: 0x1451C0 Offset: 0x1452C1 VA: 0x1451C0
public class Actor // TypeDefIndex: 6299
{
	// Fields
	private GameObject gameObject; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x15BEB0 Offset: 0x15BFB1 VA: 0x15BEB0
	private ActorID <ActorID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15BEC0 Offset: 0x15BFC1 VA: 0x15BEC0
	private ActorType <ActorType>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x15BED0 Offset: 0x15BFD1 VA: 0x15BED0
	private ActorGroup <ActorGroup>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15BEE0 Offset: 0x15BFE1 VA: 0x15BEE0
	private CharID <CharID>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x15BEF0 Offset: 0x15BFF1 VA: 0x15BEF0
	private HairType <HairType>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15BF00 Offset: 0x15C001 VA: 0x15BF00
	private VariationNo <VariationNo>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x15BF10 Offset: 0x15C011 VA: 0x15BF10
	private bool <IsAnimatorRebind>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15BF20 Offset: 0x15C021 VA: 0x15BF20
	private Transform[] <BaseTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15BF30 Offset: 0x15C031 VA: 0x15BF30
	private ActorController[] <BaseController>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15BF40 Offset: 0x15C041 VA: 0x15BF40
	private Transform <CharacterTransform>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15BF50 Offset: 0x15C051 VA: 0x15BF50
	private CharacterStatusBase <StatusController>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15BF60 Offset: 0x15C061 VA: 0x15BF60
	private ActorController <ActiveController>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x15BF70 Offset: 0x15C071 VA: 0x15BF70
	private ActorType <PreviousActorType>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x15BF80 Offset: 0x15C081 VA: 0x15BF80
	private bool <IsCopyTransform>k__BackingField; // 0x64
	private Transform copyBaseTransform; // 0x68
	private List<Transform> deleteTransforms; // 0x70
	private Actor.State updateState; // 0x78
	private bool dispOn; // 0x7C
	private bool isBaseDestroy; // 0x7D
	private int loaderIdBase; // 0x80
	private int loaderIdChar; // 0x84
	private static Actor.UpdateVJ[] updateVJ; // 0x0

	// Properties
	public ActorID ActorID { get; set; }
	public ActorType ActorType { get; set; }
	public ActorGroup ActorGroup { get; set; }
	public CharID CharID { get; set; }
	public HairType HairType { get; set; }
	public VariationNo VariationNo { get; set; }
	public bool IsActive { get; }
	public bool DispOn { get; set; }
	public bool IsAnimatorRebind { get; set; }
	public Transform Transform { get; }
	public Transform[] BaseTransform { get; set; }
	public ActorController[] BaseController { get; set; }
	public Transform Item { get; }
	public Transform CharacterTransform { get; set; }
	public CharacterStatusBase StatusController { get; set; }
	public ActorController ActiveController { get; set; }
	public ActorType PreviousActorType { get; set; }
	public bool IsCopyTransform { get; set; }
	public bool IsPlayable { get; }
	public bool IsPartner { get; }
	public bool IsShortPlay { get; }
	public bool IsNpc { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19A930 Offset: 0x19AA31 VA: 0x19A930
	// RVA: 0x1BE4D70 Offset: 0x1BE4E71 VA: 0x1BE4D70
	public ActorID get_ActorID() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A940 Offset: 0x19AA41 VA: 0x19A940
	// RVA: 0x1BE4D80 Offset: 0x1BE4E81 VA: 0x1BE4D80
	private void set_ActorID(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A950 Offset: 0x19AA51 VA: 0x19A950
	// RVA: 0x1BE4D90 Offset: 0x1BE4E91 VA: 0x1BE4D90
	public ActorType get_ActorType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A960 Offset: 0x19AA61 VA: 0x19A960
	// RVA: 0x1BE4DA0 Offset: 0x1BE4EA1 VA: 0x1BE4DA0
	private void set_ActorType(ActorType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A970 Offset: 0x19AA71 VA: 0x19A970
	// RVA: 0x1BE4DB0 Offset: 0x1BE4EB1 VA: 0x1BE4DB0
	public ActorGroup get_ActorGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A980 Offset: 0x19AA81 VA: 0x19A980
	// RVA: 0x1BE4DC0 Offset: 0x1BE4EC1 VA: 0x1BE4DC0
	private void set_ActorGroup(ActorGroup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A990 Offset: 0x19AA91 VA: 0x19A990
	// RVA: 0x1BE4DD0 Offset: 0x1BE4ED1 VA: 0x1BE4DD0
	public CharID get_CharID() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A9A0 Offset: 0x19AAA1 VA: 0x19A9A0
	// RVA: 0x1BE4DE0 Offset: 0x1BE4EE1 VA: 0x1BE4DE0
	private void set_CharID(CharID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A9B0 Offset: 0x19AAB1 VA: 0x19A9B0
	// RVA: 0x1BE4DF0 Offset: 0x1BE4EF1 VA: 0x1BE4DF0
	public HairType get_HairType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A9C0 Offset: 0x19AAC1 VA: 0x19A9C0
	// RVA: 0x1BE4E00 Offset: 0x1BE4F01 VA: 0x1BE4E00
	private void set_HairType(HairType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A9D0 Offset: 0x19AAD1 VA: 0x19A9D0
	// RVA: 0x1BE4E10 Offset: 0x1BE4F11 VA: 0x1BE4E10
	public VariationNo get_VariationNo() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A9E0 Offset: 0x19AAE1 VA: 0x19A9E0
	// RVA: 0x1BE4E20 Offset: 0x1BE4F21 VA: 0x1BE4E20
	private void set_VariationNo(VariationNo value) { }

	// RVA: 0x1BE4E30 Offset: 0x1BE4F31 VA: 0x1BE4E30
	public bool get_IsActive() { }

	// RVA: 0x1BE4E40 Offset: 0x1BE4F41 VA: 0x1BE4E40
	public bool get_DispOn() { }

	// RVA: 0x1BE4E50 Offset: 0x1BE4F51 VA: 0x1BE4E50
	public void set_DispOn(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A9F0 Offset: 0x19AAF1 VA: 0x19A9F0
	// RVA: 0x1BE4F10 Offset: 0x1BE5011 VA: 0x1BE4F10
	public bool get_IsAnimatorRebind() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA00 Offset: 0x19AB01 VA: 0x19AA00
	// RVA: 0x1BE4F20 Offset: 0x1BE5021 VA: 0x1BE4F20
	public void set_IsAnimatorRebind(bool value) { }

	// RVA: 0x1BE4F30 Offset: 0x1BE5031 VA: 0x1BE4F30
	public Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA10 Offset: 0x19AB11 VA: 0x19AA10
	// RVA: 0x1BE4F50 Offset: 0x1BE5051 VA: 0x1BE4F50
	public Transform[] get_BaseTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA20 Offset: 0x19AB21 VA: 0x19AA20
	// RVA: 0x1BE4F60 Offset: 0x1BE5061 VA: 0x1BE4F60
	private void set_BaseTransform(Transform[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA30 Offset: 0x19AB31 VA: 0x19AA30
	// RVA: 0x1BE4F70 Offset: 0x1BE5071 VA: 0x1BE4F70
	public ActorController[] get_BaseController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA40 Offset: 0x19AB41 VA: 0x19AA40
	// RVA: 0x1BE4F80 Offset: 0x1BE5081 VA: 0x1BE4F80
	private void set_BaseController(ActorController[] value) { }

	// RVA: 0x1BE4F90 Offset: 0x1BE5091 VA: 0x1BE4F90
	public Transform get_Item(ActorType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA50 Offset: 0x19AB51 VA: 0x19AA50
	// RVA: 0x1BE4FD0 Offset: 0x1BE50D1 VA: 0x1BE4FD0
	public Transform get_CharacterTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA60 Offset: 0x19AB61 VA: 0x19AA60
	// RVA: 0x1BE4FE0 Offset: 0x1BE50E1 VA: 0x1BE4FE0
	private void set_CharacterTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA70 Offset: 0x19AB71 VA: 0x19AA70
	// RVA: 0x1BE4FF0 Offset: 0x1BE50F1 VA: 0x1BE4FF0
	public CharacterStatusBase get_StatusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA80 Offset: 0x19AB81 VA: 0x19AA80
	// RVA: 0x1BE5000 Offset: 0x1BE5101 VA: 0x1BE5000
	public void set_StatusController(CharacterStatusBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AA90 Offset: 0x19AB91 VA: 0x19AA90
	// RVA: 0x1BE5010 Offset: 0x1BE5111 VA: 0x1BE5010
	public ActorController get_ActiveController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AAA0 Offset: 0x19ABA1 VA: 0x19AAA0
	// RVA: 0x1BE5020 Offset: 0x1BE5121 VA: 0x1BE5020
	private void set_ActiveController(ActorController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AAB0 Offset: 0x19ABB1 VA: 0x19AAB0
	// RVA: 0x1BE5030 Offset: 0x1BE5131 VA: 0x1BE5030
	public ActorType get_PreviousActorType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AAC0 Offset: 0x19ABC1 VA: 0x19AAC0
	// RVA: 0x1BE5040 Offset: 0x1BE5141 VA: 0x1BE5040
	private void set_PreviousActorType(ActorType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AAD0 Offset: 0x19ABD1 VA: 0x19AAD0
	// RVA: 0x1BE5050 Offset: 0x1BE5151 VA: 0x1BE5050
	public bool get_IsCopyTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AAE0 Offset: 0x19ABE1 VA: 0x19AAE0
	// RVA: 0x1BE5060 Offset: 0x1BE5161 VA: 0x1BE5060
	public void set_IsCopyTransform(bool value) { }

	// RVA: 0x1BE5070 Offset: 0x1BE5171 VA: 0x1BE5070
	public bool get_IsPlayable() { }

	// RVA: 0x1BE5080 Offset: 0x1BE5181 VA: 0x1BE5080
	public bool get_IsPartner() { }

	// RVA: 0x1BE5090 Offset: 0x1BE5191 VA: 0x1BE5090
	public bool get_IsShortPlay() { }

	// RVA: 0x1BE50A0 Offset: 0x1BE51A1 VA: 0x1BE50A0
	public bool get_IsNpc() { }

	// RVA: 0x1BE50B0 Offset: 0x1BE51B1 VA: 0x1BE50B0
	public ActorController GetController(ActorType type) { }

	// RVA: 0x1BE50F0 Offset: 0x1BE51F1 VA: 0x1BE50F0
	public void InitCharacterTransform() { }

	// RVA: 0x1BE51F0 Offset: 0x1BE52F1 VA: 0x1BE51F0
	public void Create(ActorType actor_type, CharID char_id, VariationNo varia_no, HairType hair_type) { }

	// RVA: 0x1BE5800 Offset: 0x1BE5901 VA: 0x1BE5800
	public void CreateBaseOnly(ActorType actor_type, CharID char_id, VariationNo varia_no, HairType hair_type) { }

	// RVA: 0x1BE5450 Offset: 0x1BE5551 VA: 0x1BE5450
	private bool CreateActor(Actor.State nextState, ActorType actor_type, CharID char_id, VariationNo varia_no, HairType hair_type) { }

	// RVA: 0x1BE52C0 Offset: 0x1BE53C1 VA: 0x1BE52C0
	private Actor.State CreateChoice(ActorType actor_type, CharID char_id, VariationNo varia_no, HairType hair_type) { }

	// RVA: 0x1BE5B70 Offset: 0x1BE5C71 VA: 0x1BE5B70
	public void Create(ActorType actor_type, CharID char_id) { }

	// RVA: 0x1BE5B80 Offset: 0x1BE5C81 VA: 0x1BE5B80
	public void Create() { }

	// RVA: 0x1BE5B90 Offset: 0x1BE5C91 VA: 0x1BE5B90
	public void CreateRandom(ActorType actor_type = 3) { }

	// RVA: 0x1BE5990 Offset: 0x1BE5A91 VA: 0x1BE5990
	public void SwitchBase(ActorType actor_type, bool is_copy = True) { }

	// RVA: 0x1BE6160 Offset: 0x1BE6261 VA: 0x1BE6160
	public void SetMonster(ActorType actor_type, int base_loader_id, Transform transform, bool is_copy = True) { }

	// RVA: 0x1BE62F0 Offset: 0x1BE63F1 VA: 0x1BE62F0
	public void SetMonster(ActorType actor_type, Transform baseTransform, bool is_copy = True) { }

	// RVA: 0x1BE6980 Offset: 0x1BE6A81 VA: 0x1BE6980
	public void SetMonster(ActorType actor_type, Transform baseTransform, Transform transform, bool is_copy = True) { }

	// RVA: 0x1BE6BE0 Offset: 0x1BE6CE1 VA: 0x1BE6BE0
	public MonsterControllerBase ReleaseMonster() { }

	// RVA: 0x1BE6F30 Offset: 0x1BE7031 VA: 0x1BE6F30
	public void Delete() { }

	// RVA: 0x1BE7090 Offset: 0x1BE7191 VA: 0x1BE7090
	public void DeleteModel() { }

	// RVA: 0x1BE7320 Offset: 0x1BE7421 VA: 0x1BE7320
	public void .ctor(ActorID id, ActorGroup group, Transform parent) { }

	// RVA: 0x1BE74F0 Offset: 0x1BE75F1 VA: 0x1BE74F0
	public void Destroy() { }

	// RVA: 0x1BE6C90 Offset: 0x1BE6D91 VA: 0x1BE6C90
	private void Init() { }

	// RVA: 0x1BE75A0 Offset: 0x1BE76A1 VA: 0x1BE75A0
	public void Update() { }

	// RVA: 0x1BE7A10 Offset: 0x1BE7B11 VA: 0x1BE7A10
	private static void UpdateDummy(Actor actor) { }

	// RVA: 0x1BE7A20 Offset: 0x1BE7B21 VA: 0x1BE7A20
	private static void UpdateCreateBase(Actor actor) { }

	// RVA: 0x1BE7C40 Offset: 0x1BE7D41 VA: 0x1BE7C40
	private static void UpdateCreateChar(Actor actor) { }

	// RVA: 0x1BE7E90 Offset: 0x1BE7F91 VA: 0x1BE7E90
	private static void UpdateCreateBaseOnly(Actor actor) { }

	// RVA: 0x1BE66F0 Offset: 0x1BE67F1 VA: 0x1BE66F0
	private static void UpdateComplete(Actor actor) { }

	// RVA: 0x1BE7130 Offset: 0x1BE7231 VA: 0x1BE7130
	private void DestroyObject(Transform transform) { }

	// RVA: 0x1BE5E40 Offset: 0x1BE5F41 VA: 0x1BE5E40
	private void ResetBase() { }

	// RVA: 0x1BE6F60 Offset: 0x1BE7061 VA: 0x1BE6F60
	private void DestroyBase() { }

	// RVA: 0x1BE80A0 Offset: 0x1BE81A1 VA: 0x1BE80A0
	private void DestroyBase(ActorType actor_type) { }

	// RVA: 0x1BE6540 Offset: 0x1BE6641 VA: 0x1BE6540
	private void SetNewBase(ActorType actor_type, Transform new_base) { }

	// RVA: 0x1BE5870 Offset: 0x1BE5971 VA: 0x1BE5870
	private void BeforeSwitchBase(ActorType actorType) { }

	// RVA: 0x1BE5C90 Offset: 0x1BE5D91 VA: 0x1BE5C90
	private void CopyBaseTransform(Transform setTransform, Transform copyTransform) { }

	// RVA: 0x1BE8250 Offset: 0x1BE8351 VA: 0x1BE8250
	public string GetActorInfomation() { }

	// RVA: 0x1BE85D0 Offset: 0x1BE86D1 VA: 0x1BE85D0
	public string GetBaseInfomation() { }

	// RVA: 0x1BE8A10 Offset: 0x1BE8B11 VA: 0x1BE8A10
	private static void .cctor() { }
}

