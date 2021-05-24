[DefaultMemberAttribute] // RVA: 0x14A700 Offset: 0x14A801 VA: 0x14A700
[Serializable]
public class TableBase<TKey, TValue, Type> // TypeDefIndex: 10641
{
	// Fields
	[SerializeField] // RVA: 0x181F30 Offset: 0x182031 VA: 0x181F30
	private List<Type> list; // 0x0
	private Dictionary<TKey, TValue> table; // 0x0

	// Properties
	public TValue Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> GetTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE430 Offset: 0x2CAE531 VA: 0x2CAE430
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.GetTable
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>.GetTable
	|-TableBase<Season, string, SeasonTextureDataPair>.GetTable
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>.GetTable
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.GetTable
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>.GetTable
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>.GetTable
	|-TableBase<Int32Enum, object, object>.GetTable
	|
	|-RVA: 0x2CAEA00 Offset: 0x2CAEB01 VA: 0x2CAEA00
	|-TableBase<object, object, object>.GetTable
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>.GetTable
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>.GetTable
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>.GetTable
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>.GetTable
	|-TableBase<string, GameObject, PositinoListPair>.GetTable
	|
	|-RVA: 0x2CAEFC0 Offset: 0x2CAF0C1 VA: 0x2CAEFC0
	|-TableBase<object, float, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	public List<Type> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE4C0 Offset: 0x2CAE5C1 VA: 0x2CAE4C0
	|-TableBase<Int32Enum, object, object>.GetList
	|
	|-RVA: 0x2CAEA90 Offset: 0x2CAEB91 VA: 0x2CAEA90
	|-TableBase<object, object, object>.GetList
	|
	|-RVA: 0x2CAF050 Offset: 0x2CAF151 VA: 0x2CAF050
	|-TableBase<object, float, object>.GetList
	*/

	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> ConvertListToDictionary(List<Type> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE550 Offset: 0x2CAE651 VA: 0x2CAE550
	|-TableBase<Int32Enum, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAEB20 Offset: 0x2CAEC21 VA: 0x2CAEB20
	|-TableBase<object, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAF0E0 Offset: 0x2CAF1E1 VA: 0x2CAF0E0
	|-TableBase<object, float, object>.ConvertListToDictionary
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE8D0 Offset: 0x2CAE9D1 VA: 0x2CAE8D0
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>.get_Item
	|-TableBase<Int32Enum, object, object>.get_Item
	|
	|-RVA: 0x2CAEE90 Offset: 0x2CAEF91 VA: 0x2CAEE90
	|-TableBase<object, object, object>.get_Item
	|
	|-RVA: 0x2CAF460 Offset: 0x2CAF561 VA: 0x2CAF460
	|-TableBase<object, float, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE930 Offset: 0x2CAEA31 VA: 0x2CAE930
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.ContainsKey
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.ContainsKey
	|-TableBase<Int32Enum, object, object>.ContainsKey
	|
	|-RVA: 0x2CAEEF0 Offset: 0x2CAEFF1 VA: 0x2CAEEF0
	|-TableBase<object, object, object>.ContainsKey
	|
	|-RVA: 0x2CAF4C0 Offset: 0x2CAF5C1 VA: 0x2CAF4C0
	|-TableBase<object, float, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE990 Offset: 0x2CAEA91 VA: 0x2CAE990
	|-TableBase<Int32Enum, object, object>.get_Count
	|
	|-RVA: 0x2CAEF50 Offset: 0x2CAF051 VA: 0x2CAEF50
	|-TableBase<object, object, object>.get_Count
	|
	|-RVA: 0x2CAF520 Offset: 0x2CAF621 VA: 0x2CAF520
	|-TableBase<object, float, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE9E0 Offset: 0x2CAEAE1 VA: 0x2CAE9E0
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>..ctor
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>..ctor
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>..ctor
	|-TableBase<Season, string, SeasonMaterialDataPair>..ctor
	|-TableBase<Season, string, SeasonTextureDataPair>..ctor
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>..ctor
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>..ctor
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>..ctor
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>..ctor
	|-TableBase<Int32Enum, object, object>..ctor
	|
	|-RVA: 0x2CAEFA0 Offset: 0x2CAF0A1 VA: 0x2CAEFA0
	|-TableBase<object, object, object>..ctor
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>..ctor
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>..ctor
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>..ctor
	|-TableBase<string, TeleportPositionData, TeleportPositionDataTablePair>..ctor
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>..ctor
	|-TableBase<string, AnimationCurve, TimeScaleListPair>..ctor
	|-TableBase<string, GameObject, PositinoListPair>..ctor
	|
	|-RVA: 0x2CAF570 Offset: 0x2CAF671 VA: 0x2CAF570
	|-TableBase<object, float, object>..ctor
	|-TableBase<string, float, DefinitionPair>..ctor
	*/
}

[DefaultMemberAttribute] // RVA: 0x14A700 Offset: 0x14A801 VA: 0x14A700
[Serializable]
public class TableBase<TKey, TValue, Type> // TypeDefIndex: 10641
{
	// Fields
	[SerializeField] // RVA: 0x181F30 Offset: 0x182031 VA: 0x181F30
	private List<Type> list; // 0x0
	private Dictionary<TKey, TValue> table; // 0x0

	// Properties
	public TValue Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> GetTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE430 Offset: 0x2CAE531 VA: 0x2CAE430
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.GetTable
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>.GetTable
	|-TableBase<Season, string, SeasonTextureDataPair>.GetTable
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>.GetTable
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.GetTable
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>.GetTable
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>.GetTable
	|-TableBase<Int32Enum, object, object>.GetTable
	|
	|-RVA: 0x2CAEA00 Offset: 0x2CAEB01 VA: 0x2CAEA00
	|-TableBase<object, object, object>.GetTable
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>.GetTable
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>.GetTable
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>.GetTable
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>.GetTable
	|-TableBase<string, GameObject, PositinoListPair>.GetTable
	|
	|-RVA: 0x2CAEFC0 Offset: 0x2CAF0C1 VA: 0x2CAEFC0
	|-TableBase<object, float, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	public List<Type> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE4C0 Offset: 0x2CAE5C1 VA: 0x2CAE4C0
	|-TableBase<Int32Enum, object, object>.GetList
	|
	|-RVA: 0x2CAEA90 Offset: 0x2CAEB91 VA: 0x2CAEA90
	|-TableBase<object, object, object>.GetList
	|
	|-RVA: 0x2CAF050 Offset: 0x2CAF151 VA: 0x2CAF050
	|-TableBase<object, float, object>.GetList
	*/

	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> ConvertListToDictionary(List<Type> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE550 Offset: 0x2CAE651 VA: 0x2CAE550
	|-TableBase<Int32Enum, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAEB20 Offset: 0x2CAEC21 VA: 0x2CAEB20
	|-TableBase<object, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAF0E0 Offset: 0x2CAF1E1 VA: 0x2CAF0E0
	|-TableBase<object, float, object>.ConvertListToDictionary
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE8D0 Offset: 0x2CAE9D1 VA: 0x2CAE8D0
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>.get_Item
	|-TableBase<Int32Enum, object, object>.get_Item
	|
	|-RVA: 0x2CAEE90 Offset: 0x2CAEF91 VA: 0x2CAEE90
	|-TableBase<object, object, object>.get_Item
	|
	|-RVA: 0x2CAF460 Offset: 0x2CAF561 VA: 0x2CAF460
	|-TableBase<object, float, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE930 Offset: 0x2CAEA31 VA: 0x2CAE930
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.ContainsKey
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.ContainsKey
	|-TableBase<Int32Enum, object, object>.ContainsKey
	|
	|-RVA: 0x2CAEEF0 Offset: 0x2CAEFF1 VA: 0x2CAEEF0
	|-TableBase<object, object, object>.ContainsKey
	|
	|-RVA: 0x2CAF4C0 Offset: 0x2CAF5C1 VA: 0x2CAF4C0
	|-TableBase<object, float, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE990 Offset: 0x2CAEA91 VA: 0x2CAE990
	|-TableBase<Int32Enum, object, object>.get_Count
	|
	|-RVA: 0x2CAEF50 Offset: 0x2CAF051 VA: 0x2CAEF50
	|-TableBase<object, object, object>.get_Count
	|
	|-RVA: 0x2CAF520 Offset: 0x2CAF621 VA: 0x2CAF520
	|-TableBase<object, float, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE9E0 Offset: 0x2CAEAE1 VA: 0x2CAE9E0
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>..ctor
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>..ctor
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>..ctor
	|-TableBase<Season, string, SeasonMaterialDataPair>..ctor
	|-TableBase<Season, string, SeasonTextureDataPair>..ctor
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>..ctor
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>..ctor
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>..ctor
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>..ctor
	|-TableBase<Int32Enum, object, object>..ctor
	|
	|-RVA: 0x2CAEFA0 Offset: 0x2CAF0A1 VA: 0x2CAEFA0
	|-TableBase<object, object, object>..ctor
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>..ctor
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>..ctor
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>..ctor
	|-TableBase<string, TeleportPositionData, TeleportPositionDataTablePair>..ctor
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>..ctor
	|-TableBase<string, AnimationCurve, TimeScaleListPair>..ctor
	|-TableBase<string, GameObject, PositinoListPair>..ctor
	|
	|-RVA: 0x2CAF570 Offset: 0x2CAF671 VA: 0x2CAF570
	|-TableBase<object, float, object>..ctor
	|-TableBase<string, float, DefinitionPair>..ctor
	*/
}

[DefaultMemberAttribute] // RVA: 0x14A700 Offset: 0x14A801 VA: 0x14A700
[Serializable]
public class TableBase<TKey, TValue, Type> // TypeDefIndex: 10641
{
	// Fields
	[SerializeField] // RVA: 0x181F30 Offset: 0x182031 VA: 0x181F30
	private List<Type> list; // 0x0
	private Dictionary<TKey, TValue> table; // 0x0

	// Properties
	public TValue Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> GetTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE430 Offset: 0x2CAE531 VA: 0x2CAE430
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.GetTable
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>.GetTable
	|-TableBase<Season, string, SeasonTextureDataPair>.GetTable
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>.GetTable
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.GetTable
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>.GetTable
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>.GetTable
	|-TableBase<Int32Enum, object, object>.GetTable
	|
	|-RVA: 0x2CAEA00 Offset: 0x2CAEB01 VA: 0x2CAEA00
	|-TableBase<object, object, object>.GetTable
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>.GetTable
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>.GetTable
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>.GetTable
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>.GetTable
	|-TableBase<string, GameObject, PositinoListPair>.GetTable
	|
	|-RVA: 0x2CAEFC0 Offset: 0x2CAF0C1 VA: 0x2CAEFC0
	|-TableBase<object, float, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	public List<Type> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE4C0 Offset: 0x2CAE5C1 VA: 0x2CAE4C0
	|-TableBase<Int32Enum, object, object>.GetList
	|
	|-RVA: 0x2CAEA90 Offset: 0x2CAEB91 VA: 0x2CAEA90
	|-TableBase<object, object, object>.GetList
	|
	|-RVA: 0x2CAF050 Offset: 0x2CAF151 VA: 0x2CAF050
	|-TableBase<object, float, object>.GetList
	*/

	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> ConvertListToDictionary(List<Type> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE550 Offset: 0x2CAE651 VA: 0x2CAE550
	|-TableBase<Int32Enum, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAEB20 Offset: 0x2CAEC21 VA: 0x2CAEB20
	|-TableBase<object, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAF0E0 Offset: 0x2CAF1E1 VA: 0x2CAF0E0
	|-TableBase<object, float, object>.ConvertListToDictionary
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE8D0 Offset: 0x2CAE9D1 VA: 0x2CAE8D0
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>.get_Item
	|-TableBase<Int32Enum, object, object>.get_Item
	|
	|-RVA: 0x2CAEE90 Offset: 0x2CAEF91 VA: 0x2CAEE90
	|-TableBase<object, object, object>.get_Item
	|
	|-RVA: 0x2CAF460 Offset: 0x2CAF561 VA: 0x2CAF460
	|-TableBase<object, float, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE930 Offset: 0x2CAEA31 VA: 0x2CAE930
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.ContainsKey
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.ContainsKey
	|-TableBase<Int32Enum, object, object>.ContainsKey
	|
	|-RVA: 0x2CAEEF0 Offset: 0x2CAEFF1 VA: 0x2CAEEF0
	|-TableBase<object, object, object>.ContainsKey
	|
	|-RVA: 0x2CAF4C0 Offset: 0x2CAF5C1 VA: 0x2CAF4C0
	|-TableBase<object, float, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE990 Offset: 0x2CAEA91 VA: 0x2CAE990
	|-TableBase<Int32Enum, object, object>.get_Count
	|
	|-RVA: 0x2CAEF50 Offset: 0x2CAF051 VA: 0x2CAEF50
	|-TableBase<object, object, object>.get_Count
	|
	|-RVA: 0x2CAF520 Offset: 0x2CAF621 VA: 0x2CAF520
	|-TableBase<object, float, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE9E0 Offset: 0x2CAEAE1 VA: 0x2CAE9E0
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>..ctor
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>..ctor
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>..ctor
	|-TableBase<Season, string, SeasonMaterialDataPair>..ctor
	|-TableBase<Season, string, SeasonTextureDataPair>..ctor
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>..ctor
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>..ctor
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>..ctor
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>..ctor
	|-TableBase<Int32Enum, object, object>..ctor
	|
	|-RVA: 0x2CAEFA0 Offset: 0x2CAF0A1 VA: 0x2CAEFA0
	|-TableBase<object, object, object>..ctor
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>..ctor
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>..ctor
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>..ctor
	|-TableBase<string, TeleportPositionData, TeleportPositionDataTablePair>..ctor
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>..ctor
	|-TableBase<string, AnimationCurve, TimeScaleListPair>..ctor
	|-TableBase<string, GameObject, PositinoListPair>..ctor
	|
	|-RVA: 0x2CAF570 Offset: 0x2CAF671 VA: 0x2CAF570
	|-TableBase<object, float, object>..ctor
	|-TableBase<string, float, DefinitionPair>..ctor
	*/
}

[DefaultMemberAttribute] // RVA: 0x14A700 Offset: 0x14A801 VA: 0x14A700
[Serializable]
public class TableBase<TKey, TValue, Type> // TypeDefIndex: 10641
{
	// Fields
	[SerializeField] // RVA: 0x181F30 Offset: 0x182031 VA: 0x181F30
	private List<Type> list; // 0x0
	private Dictionary<TKey, TValue> table; // 0x0

	// Properties
	public TValue Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> GetTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE430 Offset: 0x2CAE531 VA: 0x2CAE430
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.GetTable
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>.GetTable
	|-TableBase<Season, string, SeasonTextureDataPair>.GetTable
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>.GetTable
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.GetTable
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>.GetTable
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>.GetTable
	|-TableBase<Int32Enum, object, object>.GetTable
	|
	|-RVA: 0x2CAEA00 Offset: 0x2CAEB01 VA: 0x2CAEA00
	|-TableBase<object, object, object>.GetTable
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>.GetTable
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>.GetTable
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>.GetTable
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>.GetTable
	|-TableBase<string, GameObject, PositinoListPair>.GetTable
	|
	|-RVA: 0x2CAEFC0 Offset: 0x2CAF0C1 VA: 0x2CAEFC0
	|-TableBase<object, float, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	public List<Type> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE4C0 Offset: 0x2CAE5C1 VA: 0x2CAE4C0
	|-TableBase<Int32Enum, object, object>.GetList
	|
	|-RVA: 0x2CAEA90 Offset: 0x2CAEB91 VA: 0x2CAEA90
	|-TableBase<object, object, object>.GetList
	|
	|-RVA: 0x2CAF050 Offset: 0x2CAF151 VA: 0x2CAF050
	|-TableBase<object, float, object>.GetList
	*/

	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> ConvertListToDictionary(List<Type> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE550 Offset: 0x2CAE651 VA: 0x2CAE550
	|-TableBase<Int32Enum, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAEB20 Offset: 0x2CAEC21 VA: 0x2CAEB20
	|-TableBase<object, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAF0E0 Offset: 0x2CAF1E1 VA: 0x2CAF0E0
	|-TableBase<object, float, object>.ConvertListToDictionary
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE8D0 Offset: 0x2CAE9D1 VA: 0x2CAE8D0
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>.get_Item
	|-TableBase<Int32Enum, object, object>.get_Item
	|
	|-RVA: 0x2CAEE90 Offset: 0x2CAEF91 VA: 0x2CAEE90
	|-TableBase<object, object, object>.get_Item
	|
	|-RVA: 0x2CAF460 Offset: 0x2CAF561 VA: 0x2CAF460
	|-TableBase<object, float, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE930 Offset: 0x2CAEA31 VA: 0x2CAE930
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.ContainsKey
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.ContainsKey
	|-TableBase<Int32Enum, object, object>.ContainsKey
	|
	|-RVA: 0x2CAEEF0 Offset: 0x2CAEFF1 VA: 0x2CAEEF0
	|-TableBase<object, object, object>.ContainsKey
	|
	|-RVA: 0x2CAF4C0 Offset: 0x2CAF5C1 VA: 0x2CAF4C0
	|-TableBase<object, float, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE990 Offset: 0x2CAEA91 VA: 0x2CAE990
	|-TableBase<Int32Enum, object, object>.get_Count
	|
	|-RVA: 0x2CAEF50 Offset: 0x2CAF051 VA: 0x2CAEF50
	|-TableBase<object, object, object>.get_Count
	|
	|-RVA: 0x2CAF520 Offset: 0x2CAF621 VA: 0x2CAF520
	|-TableBase<object, float, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE9E0 Offset: 0x2CAEAE1 VA: 0x2CAE9E0
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>..ctor
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>..ctor
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>..ctor
	|-TableBase<Season, string, SeasonMaterialDataPair>..ctor
	|-TableBase<Season, string, SeasonTextureDataPair>..ctor
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>..ctor
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>..ctor
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>..ctor
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>..ctor
	|-TableBase<Int32Enum, object, object>..ctor
	|
	|-RVA: 0x2CAEFA0 Offset: 0x2CAF0A1 VA: 0x2CAEFA0
	|-TableBase<object, object, object>..ctor
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>..ctor
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>..ctor
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>..ctor
	|-TableBase<string, TeleportPositionData, TeleportPositionDataTablePair>..ctor
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>..ctor
	|-TableBase<string, AnimationCurve, TimeScaleListPair>..ctor
	|-TableBase<string, GameObject, PositinoListPair>..ctor
	|
	|-RVA: 0x2CAF570 Offset: 0x2CAF671 VA: 0x2CAF570
	|-TableBase<object, float, object>..ctor
	|-TableBase<string, float, DefinitionPair>..ctor
	*/
}

[DefaultMemberAttribute] // RVA: 0x14A700 Offset: 0x14A801 VA: 0x14A700
[Serializable]
public class TableBase<TKey, TValue, Type> // TypeDefIndex: 10641
{
	// Fields
	[SerializeField] // RVA: 0x181F30 Offset: 0x182031 VA: 0x181F30
	private List<Type> list; // 0x0
	private Dictionary<TKey, TValue> table; // 0x0

	// Properties
	public TValue Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> GetTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE430 Offset: 0x2CAE531 VA: 0x2CAE430
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.GetTable
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>.GetTable
	|-TableBase<Season, string, SeasonTextureDataPair>.GetTable
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>.GetTable
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.GetTable
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>.GetTable
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>.GetTable
	|-TableBase<Int32Enum, object, object>.GetTable
	|
	|-RVA: 0x2CAEA00 Offset: 0x2CAEB01 VA: 0x2CAEA00
	|-TableBase<object, object, object>.GetTable
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>.GetTable
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>.GetTable
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>.GetTable
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>.GetTable
	|-TableBase<string, GameObject, PositinoListPair>.GetTable
	|
	|-RVA: 0x2CAEFC0 Offset: 0x2CAF0C1 VA: 0x2CAEFC0
	|-TableBase<object, float, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	public List<Type> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE4C0 Offset: 0x2CAE5C1 VA: 0x2CAE4C0
	|-TableBase<Int32Enum, object, object>.GetList
	|
	|-RVA: 0x2CAEA90 Offset: 0x2CAEB91 VA: 0x2CAEA90
	|-TableBase<object, object, object>.GetList
	|
	|-RVA: 0x2CAF050 Offset: 0x2CAF151 VA: 0x2CAF050
	|-TableBase<object, float, object>.GetList
	*/

	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> ConvertListToDictionary(List<Type> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE550 Offset: 0x2CAE651 VA: 0x2CAE550
	|-TableBase<Int32Enum, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAEB20 Offset: 0x2CAEC21 VA: 0x2CAEB20
	|-TableBase<object, object, object>.ConvertListToDictionary
	|
	|-RVA: 0x2CAF0E0 Offset: 0x2CAF1E1 VA: 0x2CAF0E0
	|-TableBase<object, float, object>.ConvertListToDictionary
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE8D0 Offset: 0x2CAE9D1 VA: 0x2CAE8D0
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>.get_Item
	|-TableBase<Int32Enum, object, object>.get_Item
	|
	|-RVA: 0x2CAEE90 Offset: 0x2CAEF91 VA: 0x2CAEE90
	|-TableBase<object, object, object>.get_Item
	|
	|-RVA: 0x2CAF460 Offset: 0x2CAF561 VA: 0x2CAF460
	|-TableBase<object, float, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE930 Offset: 0x2CAEA31 VA: 0x2CAE930
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>.ContainsKey
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>.ContainsKey
	|-TableBase<Int32Enum, object, object>.ContainsKey
	|
	|-RVA: 0x2CAEEF0 Offset: 0x2CAEFF1 VA: 0x2CAEEF0
	|-TableBase<object, object, object>.ContainsKey
	|
	|-RVA: 0x2CAF4C0 Offset: 0x2CAF5C1 VA: 0x2CAF4C0
	|-TableBase<object, float, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE990 Offset: 0x2CAEA91 VA: 0x2CAE990
	|-TableBase<Int32Enum, object, object>.get_Count
	|
	|-RVA: 0x2CAEF50 Offset: 0x2CAF051 VA: 0x2CAEF50
	|-TableBase<object, object, object>.get_Count
	|
	|-RVA: 0x2CAF520 Offset: 0x2CAF621 VA: 0x2CAF520
	|-TableBase<object, float, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE9E0 Offset: 0x2CAEAE1 VA: 0x2CAE9E0
	|-TableBase<CharID, SerializeMobCharVariationTalkDataTableArray, SerializeMobChaTalkDataTable>..ctor
	|-TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>..ctor
	|-TableBase<GroundType, FootStepDataTable.GroupDataTable, SerializeFootStepGroupDataTable>..ctor
	|-TableBase<Season, string, SeasonMaterialDataPair>..ctor
	|-TableBase<Season, string, SeasonTextureDataPair>..ctor
	|-TableBase<TrackinCameraType, TrackingCameraSetting, TrackingCameraSettingDictionaryPair>..ctor
	|-TableBase<VariationNo, MobTalkData, SerializeMobCharVariationTalkDataTable>..ctor
	|-TableBase<VoiceGroup, CharaVoiceGroupData, SerializeCharaVoiceGroupData>..ctor
	|-TableBase<MoveParamID, CharacterMoveParam, CharacterMoveParamTablePair>..ctor
	|-TableBase<Int32Enum, object, object>..ctor
	|
	|-RVA: 0x2CAEFA0 Offset: 0x2CAF0A1 VA: 0x2CAEFA0
	|-TableBase<object, object, object>..ctor
	|-TableBase<string, SeasonMaterialData, SeasonMaterialDataTablePair>..ctor
	|-TableBase<string, SeasonTextureData, SeasonTextureDataTablePair>..ctor
	|-TableBase<string, TeleportPortalData, TeleportPositionDataPair>..ctor
	|-TableBase<string, TeleportPositionData, TeleportPositionDataTablePair>..ctor
	|-TableBase<string, TeleportSceneParam, TeleportSceneDataTablePair>..ctor
	|-TableBase<string, AnimationCurve, TimeScaleListPair>..ctor
	|-TableBase<string, GameObject, PositinoListPair>..ctor
	|
	|-RVA: 0x2CAF570 Offset: 0x2CAF671 VA: 0x2CAF570
	|-TableBase<object, float, object>..ctor
	|-TableBase<string, float, DefinitionPair>..ctor
	*/
}

