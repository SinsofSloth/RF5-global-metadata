[NativeHeaderAttribute] // RVA: 0xC6E70 Offset: 0xC6F71 VA: 0xC6E70
[NativeHeaderAttribute] // RVA: 0xC6E70 Offset: 0xC6F71 VA: 0xC6E70
[RequiredByNativeCodeAttribute] // RVA: 0xC6E70 Offset: 0xC6F71 VA: 0xC6E70
[NativeHeaderAttribute] // RVA: 0xC6E70 Offset: 0xC6F71 VA: 0xC6E70
public class Object // TypeDefIndex: 3035
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x2B6A3D0 Offset: 0x2B6A4D1 VA: 0x2B6A3D0
	public int GetInstanceID() { }

	// RVA: 0x2B6A570 Offset: 0x2B6A671 VA: 0x2B6A570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2B6A580 Offset: 0x2B6A681 VA: 0x2B6A580 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2B6A890 Offset: 0x2B6A991 VA: 0x2B6A890
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x2B6A770 Offset: 0x2B6A871 VA: 0x2B6A770
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x2B6AA00 Offset: 0x2B6AB01 VA: 0x2B6AA00
	private void EnsureRunningOnMainThread() { }

	// RVA: 0x2B6A9A0 Offset: 0x2B6AAA1 VA: 0x2B6A9A0
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x2B6AB10 Offset: 0x2B6AC11 VA: 0x2B6AB10
	private IntPtr GetCachedPtr() { }

	// RVA: 0x2B6AB20 Offset: 0x2B6AC21 VA: 0x2B6AB20
	public string get_name() { }

	// RVA: 0x2B6AC10 Offset: 0x2B6AD11 VA: 0x2B6AC10
	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6F10 Offset: 0xD7011 VA: 0xD6F10
	// RVA: 0x2B6AD10 Offset: 0x2B6AE11 VA: 0x2B6AD10
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6F30 Offset: 0xD7031 VA: 0xD6F30
	// RVA: 0x2B6B190 Offset: 0x2B6B291 VA: 0x2B6B190
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6F50 Offset: 0xD7051 VA: 0xD6F50
	// RVA: 0x2B6B650 Offset: 0x2B6B751 VA: 0x2B6B650
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6F70 Offset: 0xD7071 VA: 0xD6F70
	// RVA: 0x2B6B8B0 Offset: 0x2B6B9B1 VA: 0x2B6B8B0
	public static Object Instantiate(Object original, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6F90 Offset: 0xD7091 VA: 0xD6F90
	// RVA: 0x2B6B930 Offset: 0x2B6BA31 VA: 0x2B6B930
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266590 Offset: 0x2266691 VA: 0x2266590
	|-Object.Instantiate<AutomaticLOD>
	|-Object.Instantiate<ExternalBehavior>
	|-Object.Instantiate<SkyProfile>
	|-Object.Instantiate<MagicTestButton>
	|-Object.Instantiate<MeshSimplify>
	|-Object.Instantiate<RideChair>
	|-Object.Instantiate<TMP_Dropdown.DropdownItem>
	|-Object.Instantiate<TimelineMsgData>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<Material>
	|-Object.Instantiate<Mesh>
	|-Object.Instantiate<ParticleSystem>
	|-Object.Instantiate<ScriptableObject>
	|-Object.Instantiate<Sprite>
	|-Object.Instantiate<Dropdown.DropdownItem>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266820 Offset: 0x2266921 VA: 0x2266820
	|-Object.Instantiate<AudmuraCrystal>
	|-Object.Instantiate<EscapeShineBall>
	|-Object.Instantiate<KrakenStickController>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<ParticleSystem>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266930 Offset: 0x2266A31 VA: 0x2266930
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22666C0 Offset: 0x22667C1 VA: 0x22666C0
	|-Object.Instantiate<AdvCharaImageControl>
	|-Object.Instantiate<AdvEmoconControl>
	|-Object.Instantiate<AdvShowOneImage>
	|-Object.Instantiate<AnimImageMove>
	|-Object.Instantiate<BitBase>
	|-Object.Instantiate<CampBadStatus>
	|-Object.Instantiate<ChoiceImage>
	|-Object.Instantiate<DamageText>
	|-Object.Instantiate<DateSlotControl>
	|-Object.Instantiate<EyeMouthAnimate>
	|-Object.Instantiate<FriendPageStatusDisp>
	|-Object.Instantiate<HUDFadeMove>
	|-Object.Instantiate<ItemMoveToBasket>
	|-Object.Instantiate<MinimapIconPoint>
	|-Object.Instantiate<MovieRoomSkip>
	|-Object.Instantiate<NoChoicePopupLite>
	|-Object.Instantiate<NoChoicePopupMain>
	|-Object.Instantiate<OrderHUDBlock>
	|-Object.Instantiate<UISubtitleHUDBlock>
	|-Object.Instantiate<ButtonHintBlock>
	|-Object.Instantiate<RecipeDataDispBlock>
	|-Object.Instantiate<RecipeItemPage>
	|-Object.Instantiate<SpriteSymbolObject>
	|-Object.Instantiate<SystemTextDisp>
	|-Object.Instantiate<TwoChoicePopupLite>
	|-Object.Instantiate<TwoChoicePopupMain>
	|-Object.Instantiate<UIItemSlot>
	|-Object.Instantiate<UIOnOffAnimate>
	|-Object.Instantiate<UIRankupShineEffect>
	|-Object.Instantiate<UISaveMenuManager>
	|-Object.Instantiate<UIShopCoinAnim>
	|-Object.Instantiate<UIShopCoinGen>
	|-Object.Instantiate<UIShopItemSplash>
	|-Object.Instantiate<UIShopMoneyEffect>
	|-Object.Instantiate<Animator>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<RectTransform>
	|-Object.Instantiate<Image>
	|-Object.Instantiate<Text>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266750 Offset: 0x2266851 VA: 0x2266750
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<ParticleSystem>
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xD6FB0 Offset: 0xD70B1 VA: 0xD6FB0
	// RVA: 0x2B6BCD0 Offset: 0x2B6BDD1 VA: 0x2B6BCD0
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD7000 Offset: 0xD7101 VA: 0xD7000
	// RVA: 0x2B6BD20 Offset: 0x2B6BE21 VA: 0x2B6BD20
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xD7010 Offset: 0xD7111 VA: 0xD7010
	// RVA: 0x2B6BDC0 Offset: 0x2B6BEC1 VA: 0x2B6BDC0
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD7060 Offset: 0xD7161 VA: 0xD7060
	// RVA: 0x2B6BE10 Offset: 0x2B6BF11 VA: 0x2B6BE10
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xD7070 Offset: 0xD7171 VA: 0xD7070
	[TypeInferenceRuleAttribute] // RVA: 0xD7070 Offset: 0xD7171 VA: 0xD7070
	// RVA: 0x2B6BEB0 Offset: 0x2B6BFB1 VA: 0x2B6BEB0
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xD70C0 Offset: 0xD71C1 VA: 0xD70C0
	// RVA: 0x2B6BF00 Offset: 0x2B6C001 VA: 0x2B6BF00
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x2B6BF50 Offset: 0x2B6C051 VA: 0x2B6BF50
	public HideFlags get_hideFlags() { }

	// RVA: 0x2B68230 Offset: 0x2B68331 VA: 0x2B68230
	public void set_hideFlags(HideFlags value) { }

	[ObsoleteAttribute] // RVA: 0xD7100 Offset: 0xD7201 VA: 0xD7100
	// RVA: 0x2B6BFA0 Offset: 0x2B6C0A1 VA: 0x2B6BFA0
	public static void DestroyObject(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD7140 Offset: 0xD7241 VA: 0xD7140
	[ObsoleteAttribute] // RVA: 0xD7140 Offset: 0xD7241 VA: 0xD7140
	// RVA: 0x2B6C050 Offset: 0x2B6C151 VA: 0x2B6C050
	public static void DestroyObject(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xD7190 Offset: 0xD7291 VA: 0xD7190
	[ObsoleteAttribute] // RVA: 0xD7190 Offset: 0xD7291 VA: 0xD7190
	// RVA: 0x2B6C0F0 Offset: 0x2B6C1F1 VA: 0x2B6C0F0
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xD71F0 Offset: 0xD72F1 VA: 0xD71F0
	[ObsoleteAttribute] // RVA: 0xD71F0 Offset: 0xD72F1 VA: 0xD71F0
	// RVA: 0x2B6C140 Offset: 0x2B6C241 VA: 0x2B6C140
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7600 Offset: 0x34F7701 VA: 0x34F7600
	|-Object.FindObjectsOfType<AutomaticLOD>
	|-Object.FindObjectsOfType<TextureChangeByFlag>
	|-Object.FindObjectsOfType<VisibleChangeByFlag>
	|-Object.FindObjectsOfType<PlayerTeleport>
	|-Object.FindObjectsOfType<SeasonChangeObject>
	|-Object.FindObjectsOfType<SeasonVisibleObject>
	|-Object.FindObjectsOfType<Renderer>
	|-Object.FindObjectsOfType<Transform>
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22664A0 Offset: 0x22665A1 VA: 0x22664A0
	|-Object.FindObjectOfType<WeatherDepthCamera>
	|-Object.FindObjectOfType<UnityAudioCapture>
	|-Object.FindObjectOfType<AudioListener>
	|-Object.FindObjectOfType<EventSystem>
	|-Object.FindObjectOfType<object>
	*/

	[ObsoleteAttribute] // RVA: 0xD7250 Offset: 0xD7351 VA: 0xD7250
	// RVA: 0x2B6C190 Offset: 0x2B6C291 VA: 0x2B6C190
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x2B6B040 Offset: 0x2B6B141 VA: 0x2B6B040
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD7290 Offset: 0xD7391 VA: 0xD7290
	// RVA: 0x2B6C1A0 Offset: 0x2B6C2A1 VA: 0x2B6C1A0
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x2B6C260 Offset: 0x2B6C361 VA: 0x2B6C260 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B67F50 Offset: 0x2B68051 VA: 0x2B67F50
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x2B6C350 Offset: 0x2B6C451 VA: 0x2B6C350
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xD72B0 Offset: 0xD73B1 VA: 0xD72B0
	// RVA: 0x2B6A530 Offset: 0x2B6A631 VA: 0x2B6A530
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethodAttribute] // RVA: 0xD7300 Offset: 0xD7401 VA: 0xD7300
	// RVA: 0x2B6AAD0 Offset: 0x2B6ABD1 VA: 0x2B6AAD0
	private static bool CurrentThreadIsMainThread() { }

	[FreeFunctionAttribute] // RVA: 0xD7350 Offset: 0xD7451 VA: 0xD7350
	// RVA: 0x2B6B860 Offset: 0x2B6B961 VA: 0x2B6B860
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xD7390 Offset: 0xD7491 VA: 0xD7390
	// RVA: 0x2B6BC70 Offset: 0x2B6BD71 VA: 0x2B6BC70
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xD73D0 Offset: 0xD74D1 VA: 0xD73D0
	// RVA: 0x2B6B0D0 Offset: 0x2B6B1D1 VA: 0x2B6B0D0
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xD7410 Offset: 0xD7511 VA: 0xD7410
	// RVA: 0x2B6B580 Offset: 0x2B6B681 VA: 0x2B6B580
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xD7450 Offset: 0xD7551 VA: 0xD7450
	// RVA: 0x2B6C300 Offset: 0x2B6C401 VA: 0x2B6C300
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xD7490 Offset: 0xD7591 VA: 0xD7490
	// RVA: 0x2B6ABC0 Offset: 0x2B6ACC1 VA: 0x2B6ABC0
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xD74D0 Offset: 0xD75D1 VA: 0xD74D0
	// RVA: 0x2B6C4A0 Offset: 0x2B6C5A1 VA: 0x2B6C4A0
	internal static bool IsPersistent(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xD7510 Offset: 0xD7611 VA: 0xD7510
	// RVA: 0x2B6ACC0 Offset: 0x2B6ADC1 VA: 0x2B6ACC0
	private static void SetName(Object obj, string name) { }

	[NativeMethodAttribute] // RVA: 0xD7550 Offset: 0xD7651 VA: 0xD7550
	// RVA: 0x2B6C4F0 Offset: 0x2B6C5F1 VA: 0x2B6C4F0
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[FreeFunctionAttribute] // RVA: 0xD75A0 Offset: 0xD76A1 VA: 0xD75A0
	[VisibleToOtherModulesAttribute] // RVA: 0xD75A0 Offset: 0xD76A1 VA: 0xD75A0
	// RVA: 0x2B6C540 Offset: 0x2B6C641 VA: 0x2B6C540
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	[FreeFunctionAttribute] // RVA: 0xD75F0 Offset: 0xD76F1 VA: 0xD75F0
	[VisibleToOtherModulesAttribute] // RVA: 0xD75F0 Offset: 0xD76F1 VA: 0xD75F0
	// RVA: 0x2B6C590 Offset: 0x2B6C691 VA: 0x2B6C590
	internal static Object ForceLoadFromInstanceID(int instanceID) { }

	// RVA: 0x2B6C5E0 Offset: 0x2B6C6E1 VA: 0x2B6C5E0
	public void .ctor() { }

	// RVA: 0x2B6C5F0 Offset: 0x2B6C6F1 VA: 0x2B6C5F0
	private static void .cctor() { }

	// RVA: 0x2B6C3D0 Offset: 0x2B6C4D1 VA: 0x2B6C3D0
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x2B6C430 Offset: 0x2B6C531 VA: 0x2B6C430
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }
}

