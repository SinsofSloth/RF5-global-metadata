[CreateAssetMenuAttribute] // RVA: 0x149240 Offset: 0x149341 VA: 0x149240
public class SkyProfile : ScriptableObject // TypeDefIndex: 9675
{
	// Fields
	public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";
	[SerializeField] // RVA: 0x17D810 Offset: 0x17D911 VA: 0x17D810
	private Material m_SkyboxMaterial; // 0x18
	[SerializeField] // RVA: 0x17D820 Offset: 0x17D921 VA: 0x17D820
	private string m_ShaderName; // 0x20
	public IProfileDefinition profileDefinition; // 0x28
	public List<string> timelineManagedKeys; // 0x30
	public KeyframeGroupDictionary keyframeGroups; // 0x38
	public BoolDictionary featureStatus; // 0x40
	public LightningArtSet lightningArtSet; // 0x48
	public RainSplashArtSet rainSplashArtSet; // 0x50
	public Texture2D starLayer1DataTexture; // 0x58
	public Texture2D starLayer2DataTexture; // 0x60
	public Texture2D starLayer3DataTexture; // 0x68
	[SerializeField] // RVA: 0x17D830 Offset: 0x17D931 VA: 0x17D830
	private int m_ProfileVersion; // 0x70
	private Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo; // 0x78

	// Properties
	public Material skyboxMaterial { get; set; }
	public string shaderName { get; }
	public ProfileGroupSection[] groupDefinitions { get; }
	public ProfileFeatureSection[] featureDefinitions { get; }

	// Methods

	// RVA: 0x22BC140 Offset: 0x22BC241 VA: 0x22BC140
	public Material get_skyboxMaterial() { }

	// RVA: 0x22BC150 Offset: 0x22BC251 VA: 0x22BC150
	public void set_skyboxMaterial(Material value) { }

	// RVA: 0x22BC380 Offset: 0x22BC481 VA: 0x22BC380
	public string get_shaderName() { }

	// RVA: 0x22BC390 Offset: 0x22BC491 VA: 0x22BC390
	public ProfileGroupSection[] get_groupDefinitions() { }

	// RVA: 0x22BC450 Offset: 0x22BC551 VA: 0x22BC450
	public ProfileFeatureSection[] get_featureDefinitions() { }

	// RVA: 0x22BC510 Offset: 0x22BC611 VA: 0x22BC510
	public float GetNumberPropertyValue(string propertyKey) { }

	// RVA: 0x22B3CA0 Offset: 0x22B3DA1 VA: 0x22B3CA0
	public float GetNumberPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x22BC520 Offset: 0x22BC621 VA: 0x22BC520
	public Color GetColorPropertyValue(string propertyKey) { }

	// RVA: 0x22B3D80 Offset: 0x22B3E81 VA: 0x22B3D80
	public Color GetColorPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x22BC530 Offset: 0x22BC631 VA: 0x22BC530
	public Texture GetTexturePropertyValue(string propertyKey) { }

	// RVA: 0x22B7240 Offset: 0x22B7341 VA: 0x22B7240
	public Texture GetTexturePropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x22BC540 Offset: 0x22BC641 VA: 0x22BC540
	public SpherePoint GetSpherePointPropertyValue(string propertyKey) { }

	// RVA: 0x22BC550 Offset: 0x22BC651 VA: 0x22BC550
	public SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x22BC8F0 Offset: 0x22BC9F1 VA: 0x22BC8F0
	public bool GetBoolPropertyValue(string propertyKey) { }

	// RVA: 0x22BC900 Offset: 0x22BCA01 VA: 0x22BC900
	public bool GetBoolPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x22BC9E0 Offset: 0x22BCAE1 VA: 0x22BC9E0
	public void .ctor() { }

	// RVA: 0x22BCBB0 Offset: 0x22BCCB1 VA: 0x22BCBB0
	private void OnEnable() { }

	// RVA: 0x22BCB20 Offset: 0x22BCC21 VA: 0x22BCB20
	private void ReloadFullProfile() { }

	// RVA: 0x22BC310 Offset: 0x22BC411 VA: 0x22BC310
	private void ReloadDefinitions() { }

	// RVA: 0x22BD220 Offset: 0x22BD321 VA: 0x22BD220
	private IProfileDefinition GetShaderInfoForMaterial(string shaderName) { }

	// RVA: 0x22BCBC0 Offset: 0x22BCCC1 VA: 0x22BCBC0
	public void MergeProfileWithDefinitions() { }

	// RVA: 0x22BD280 Offset: 0x22BD381 VA: 0x22BD280
	public void MergeGroupsWithDefinitions() { }

	// RVA: 0x22BE1F0 Offset: 0x22BE2F1 VA: 0x22BE1F0
	public Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary() { }

	// RVA: 0x22BE3D0 Offset: 0x22BE4D1 VA: 0x22BE3D0
	public ProfileGroupSection[] ProfileDefinitionTable() { }

	// RVA: 0x22BDD40 Offset: 0x22BDE41 VA: 0x22BDD40
	private void AddNumericGroup(string propKey, string groupName, float min, float max, float value) { }

	// RVA: 0x22BDBD0 Offset: 0x22BDCD1 VA: 0x22BDBD0
	private void AddColorGroup(string propKey, string groupName, Color color) { }

	// RVA: 0x22BDE90 Offset: 0x22BDF91 VA: 0x22BDE90
	private void AddTextureGroup(string propKey, string groupName, Texture2D texture) { }

	// RVA: 0x22BDF80 Offset: 0x22BE081 VA: 0x22BDF80
	private void AddSpherePointGroup(string propKey, string groupName, SpherePoint point) { }

	// RVA: 0x22BE0B0 Offset: 0x22BE1B1 VA: 0x22BE0B0
	private void AddBooleanGroup(string propKey, string groupName, bool value) { }

	// RVA: -1 Offset: -1
	public T GetGroup<T>(string propertyKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1110 Offset: 0x23C1211 VA: 0x23C1110
	|-SkyProfile.GetGroup<BoolKeyframeGroup>
	|-SkyProfile.GetGroup<ColorKeyframeGroup>
	|-SkyProfile.GetGroup<NumberKeyframeGroup>
	|-SkyProfile.GetGroup<SpherePointKeyframeGroup>
	|-SkyProfile.GetGroup<TextureKeyframeGroup>
	|-SkyProfile.GetGroup<object>
	*/

	// RVA: 0x22BE5E0 Offset: 0x22BE6E1 VA: 0x22BE5E0
	public IKeyframeGroup GetGroup(string propertyKey) { }

	// RVA: 0x22BE650 Offset: 0x22BE751 VA: 0x22BE650
	public IKeyframeGroup GetGroupWithId(string groupId) { }

	// RVA: 0x22BEA00 Offset: 0x22BEB01 VA: 0x22BEA00
	public ProfileGroupSection[] GetProfileDefinitions() { }

	// RVA: 0x22BEAC0 Offset: 0x22BEBC1 VA: 0x22BEAC0
	public ProfileGroupSection GetSectionInfo(string sectionKey) { }

	// RVA: 0x22BEC00 Offset: 0x22BED01 VA: 0x22BEC00
	public bool IsManagedByTimeline(string propertyKey) { }

	// RVA: 0x22BCDC0 Offset: 0x22BCEC1 VA: 0x22BCDC0
	public void ValidateTimelineGroupKeys() { }

	// RVA: 0x22BEC70 Offset: 0x22BED71 VA: 0x22BEC70
	public List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline() { }

	// RVA: 0x22BEF30 Offset: 0x22BF031 VA: 0x22BEF30
	public List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline() { }

	// RVA: 0x22BEEB0 Offset: 0x22BEFB1 VA: 0x22BEEB0
	public ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey) { }

	// RVA: 0x22BCBF0 Offset: 0x22BCCF1 VA: 0x22BCBF0
	public void RebuildKeyToGroupInfoMapping() { }

	// RVA: 0x22BF2B0 Offset: 0x22BF3B1 VA: 0x22BF2B0
	public void TrimGroupToSingleKeyframe(string propertyKey) { }

	// RVA: 0x22BF1E0 Offset: 0x22BF2E1 VA: 0x22BF1E0
	public bool CanGroupBeOnTimeline(ProfileGroupDefinition definition) { }

	// RVA: 0x22BD980 Offset: 0x22BDA81 VA: 0x22BD980
	protected void MergeShaderKeywordsWithDefinitions() { }

	// RVA: 0x22B2B90 Offset: 0x22B2C91 VA: 0x22B2B90
	public bool IsFeatureEnabled(string featureKey, bool recursive = True) { }

	// RVA: 0x22BF3D0 Offset: 0x22BF4D1 VA: 0x22BF3D0
	public void SetFeatureEnabled(string featureKey, bool value) { }
}

