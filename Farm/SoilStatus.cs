public class SoilStatus : MonoBehaviour // TypeDefIndex: 10379
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1815D0 Offset: 0x1816D1 VA: 0x1815D0
	private bool <IsCultivated>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1815E0 Offset: 0x1816E1 VA: 0x1815E0
	private bool <IsWatering>k__BackingField; // 0x19
	private bool _nowCultivateStatus; // 0x1A
	private bool _nowWateringStatus; // 0x1B
	private GameObject _plowObj; // 0x20
	private GameObject _waterObj; // 0x28
	[SerializeField] // RVA: 0x1815F0 Offset: 0x1816F1 VA: 0x1815F0
	private GameObject _normalplowObj; // 0x30
	[SerializeField] // RVA: 0x181600 Offset: 0x181701 VA: 0x181600
	private GameObject _normalwaterObj; // 0x38
	[SerializeField] // RVA: 0x181610 Offset: 0x181711 VA: 0x181610
	private GameObject _largeplowObj; // 0x40
	[SerializeField] // RVA: 0x181620 Offset: 0x181721 VA: 0x181620
	private GameObject _largewaterObj; // 0x48
	private GameObject _focusObj; // 0x50
	private GameObject _focusObj2; // 0x58
	private int initialized; // 0x60
	private bool isLargeSoilSize; // 0x64
	private bool updateSoilSize; // 0x65

	// Properties
	public bool IsCultivated { get; set; }
	public bool IsWatering { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AED90 Offset: 0x1AEE91 VA: 0x1AED90
	// RVA: 0x20291D0 Offset: 0x20292D1 VA: 0x20291D0
	public bool get_IsCultivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDA0 Offset: 0x1AEEA1 VA: 0x1AEDA0
	// RVA: 0x20291E0 Offset: 0x20292E1 VA: 0x20291E0
	public void set_IsCultivated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDB0 Offset: 0x1AEEB1 VA: 0x1AEDB0
	// RVA: 0x20291F0 Offset: 0x20292F1 VA: 0x20291F0
	public bool get_IsWatering() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDC0 Offset: 0x1AEEC1 VA: 0x1AEDC0
	// RVA: 0x2029200 Offset: 0x2029301 VA: 0x2029200
	public void set_IsWatering(bool value) { }

	// RVA: 0x2029210 Offset: 0x2029311 VA: 0x2029210
	private void OnDestroy() { }

	// RVA: 0x2029360 Offset: 0x2029461 VA: 0x2029360
	private void Start() { }

	// RVA: 0x2029480 Offset: 0x2029581 VA: 0x2029480
	private void Update() { }

	// RVA: 0x20294B0 Offset: 0x20295B1 VA: 0x20294B0
	public void UpdateObj() { }

	// RVA: 0x20297C0 Offset: 0x20298C1 VA: 0x20297C0
	private void RemoveChildObjectsAll(Transform t) { }

	// RVA: 0x2029890 Offset: 0x2029991 VA: 0x2029890
	public void Focused(bool isFocus, bool isLarge = False) { }

	// RVA: 0x2029920 Offset: 0x2029A21 VA: 0x2029920
	public void ChangeSoilSize(bool isLarge) { }

	// RVA: 0x20295A0 Offset: 0x20296A1 VA: 0x20295A0
	private void UpdateSoilSize() { }

	// RVA: 0x20297B0 Offset: 0x20298B1 VA: 0x20297B0
	private bool Initialized() { }

	// RVA: 0x2029940 Offset: 0x2029A41 VA: 0x2029940
	public void ChangeCursorColor(bool isOk) { }

	// RVA: 0x2029A90 Offset: 0x2029B91 VA: 0x2029A90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDD0 Offset: 0x1AEED1 VA: 0x1AEDD0
	// RVA: 0x2029AA0 Offset: 0x2029BA1 VA: 0x2029AA0
	private void <Start>b__22_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDE0 Offset: 0x1AEEE1 VA: 0x1AEDE0
	// RVA: 0x2029BD0 Offset: 0x2029CD1 VA: 0x2029BD0
	private void <Start>b__22_1(AssetHandle<GameObject> handle) { }
}

public class SoilStatus : MonoBehaviour // TypeDefIndex: 10379
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1815D0 Offset: 0x1816D1 VA: 0x1815D0
	private bool <IsCultivated>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1815E0 Offset: 0x1816E1 VA: 0x1815E0
	private bool <IsWatering>k__BackingField; // 0x19
	private bool _nowCultivateStatus; // 0x1A
	private bool _nowWateringStatus; // 0x1B
	private GameObject _plowObj; // 0x20
	private GameObject _waterObj; // 0x28
	[SerializeField] // RVA: 0x1815F0 Offset: 0x1816F1 VA: 0x1815F0
	private GameObject _normalplowObj; // 0x30
	[SerializeField] // RVA: 0x181600 Offset: 0x181701 VA: 0x181600
	private GameObject _normalwaterObj; // 0x38
	[SerializeField] // RVA: 0x181610 Offset: 0x181711 VA: 0x181610
	private GameObject _largeplowObj; // 0x40
	[SerializeField] // RVA: 0x181620 Offset: 0x181721 VA: 0x181620
	private GameObject _largewaterObj; // 0x48
	private GameObject _focusObj; // 0x50
	private GameObject _focusObj2; // 0x58
	private int initialized; // 0x60
	private bool isLargeSoilSize; // 0x64
	private bool updateSoilSize; // 0x65

	// Properties
	public bool IsCultivated { get; set; }
	public bool IsWatering { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AED90 Offset: 0x1AEE91 VA: 0x1AED90
	// RVA: 0x20291D0 Offset: 0x20292D1 VA: 0x20291D0
	public bool get_IsCultivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDA0 Offset: 0x1AEEA1 VA: 0x1AEDA0
	// RVA: 0x20291E0 Offset: 0x20292E1 VA: 0x20291E0
	public void set_IsCultivated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDB0 Offset: 0x1AEEB1 VA: 0x1AEDB0
	// RVA: 0x20291F0 Offset: 0x20292F1 VA: 0x20291F0
	public bool get_IsWatering() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDC0 Offset: 0x1AEEC1 VA: 0x1AEDC0
	// RVA: 0x2029200 Offset: 0x2029301 VA: 0x2029200
	public void set_IsWatering(bool value) { }

	// RVA: 0x2029210 Offset: 0x2029311 VA: 0x2029210
	private void OnDestroy() { }

	// RVA: 0x2029360 Offset: 0x2029461 VA: 0x2029360
	private void Start() { }

	// RVA: 0x2029480 Offset: 0x2029581 VA: 0x2029480
	private void Update() { }

	// RVA: 0x20294B0 Offset: 0x20295B1 VA: 0x20294B0
	public void UpdateObj() { }

	// RVA: 0x20297C0 Offset: 0x20298C1 VA: 0x20297C0
	private void RemoveChildObjectsAll(Transform t) { }

	// RVA: 0x2029890 Offset: 0x2029991 VA: 0x2029890
	public void Focused(bool isFocus, bool isLarge = False) { }

	// RVA: 0x2029920 Offset: 0x2029A21 VA: 0x2029920
	public void ChangeSoilSize(bool isLarge) { }

	// RVA: 0x20295A0 Offset: 0x20296A1 VA: 0x20295A0
	private void UpdateSoilSize() { }

	// RVA: 0x20297B0 Offset: 0x20298B1 VA: 0x20297B0
	private bool Initialized() { }

	// RVA: 0x2029940 Offset: 0x2029A41 VA: 0x2029940
	public void ChangeCursorColor(bool isOk) { }

	// RVA: 0x2029A90 Offset: 0x2029B91 VA: 0x2029A90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDD0 Offset: 0x1AEED1 VA: 0x1AEDD0
	// RVA: 0x2029AA0 Offset: 0x2029BA1 VA: 0x2029AA0
	private void <Start>b__22_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDE0 Offset: 0x1AEEE1 VA: 0x1AEDE0
	// RVA: 0x2029BD0 Offset: 0x2029CD1 VA: 0x2029BD0
	private void <Start>b__22_1(AssetHandle<GameObject> handle) { }
}

public class SoilStatus : MonoBehaviour // TypeDefIndex: 10379
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1815D0 Offset: 0x1816D1 VA: 0x1815D0
	private bool <IsCultivated>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1815E0 Offset: 0x1816E1 VA: 0x1815E0
	private bool <IsWatering>k__BackingField; // 0x19
	private bool _nowCultivateStatus; // 0x1A
	private bool _nowWateringStatus; // 0x1B
	private GameObject _plowObj; // 0x20
	private GameObject _waterObj; // 0x28
	[SerializeField] // RVA: 0x1815F0 Offset: 0x1816F1 VA: 0x1815F0
	private GameObject _normalplowObj; // 0x30
	[SerializeField] // RVA: 0x181600 Offset: 0x181701 VA: 0x181600
	private GameObject _normalwaterObj; // 0x38
	[SerializeField] // RVA: 0x181610 Offset: 0x181711 VA: 0x181610
	private GameObject _largeplowObj; // 0x40
	[SerializeField] // RVA: 0x181620 Offset: 0x181721 VA: 0x181620
	private GameObject _largewaterObj; // 0x48
	private GameObject _focusObj; // 0x50
	private GameObject _focusObj2; // 0x58
	private int initialized; // 0x60
	private bool isLargeSoilSize; // 0x64
	private bool updateSoilSize; // 0x65

	// Properties
	public bool IsCultivated { get; set; }
	public bool IsWatering { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AED90 Offset: 0x1AEE91 VA: 0x1AED90
	// RVA: 0x20291D0 Offset: 0x20292D1 VA: 0x20291D0
	public bool get_IsCultivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDA0 Offset: 0x1AEEA1 VA: 0x1AEDA0
	// RVA: 0x20291E0 Offset: 0x20292E1 VA: 0x20291E0
	public void set_IsCultivated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDB0 Offset: 0x1AEEB1 VA: 0x1AEDB0
	// RVA: 0x20291F0 Offset: 0x20292F1 VA: 0x20291F0
	public bool get_IsWatering() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDC0 Offset: 0x1AEEC1 VA: 0x1AEDC0
	// RVA: 0x2029200 Offset: 0x2029301 VA: 0x2029200
	public void set_IsWatering(bool value) { }

	// RVA: 0x2029210 Offset: 0x2029311 VA: 0x2029210
	private void OnDestroy() { }

	// RVA: 0x2029360 Offset: 0x2029461 VA: 0x2029360
	private void Start() { }

	// RVA: 0x2029480 Offset: 0x2029581 VA: 0x2029480
	private void Update() { }

	// RVA: 0x20294B0 Offset: 0x20295B1 VA: 0x20294B0
	public void UpdateObj() { }

	// RVA: 0x20297C0 Offset: 0x20298C1 VA: 0x20297C0
	private void RemoveChildObjectsAll(Transform t) { }

	// RVA: 0x2029890 Offset: 0x2029991 VA: 0x2029890
	public void Focused(bool isFocus, bool isLarge = False) { }

	// RVA: 0x2029920 Offset: 0x2029A21 VA: 0x2029920
	public void ChangeSoilSize(bool isLarge) { }

	// RVA: 0x20295A0 Offset: 0x20296A1 VA: 0x20295A0
	private void UpdateSoilSize() { }

	// RVA: 0x20297B0 Offset: 0x20298B1 VA: 0x20297B0
	private bool Initialized() { }

	// RVA: 0x2029940 Offset: 0x2029A41 VA: 0x2029940
	public void ChangeCursorColor(bool isOk) { }

	// RVA: 0x2029A90 Offset: 0x2029B91 VA: 0x2029A90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDD0 Offset: 0x1AEED1 VA: 0x1AEDD0
	// RVA: 0x2029AA0 Offset: 0x2029BA1 VA: 0x2029AA0
	private void <Start>b__22_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDE0 Offset: 0x1AEEE1 VA: 0x1AEDE0
	// RVA: 0x2029BD0 Offset: 0x2029CD1 VA: 0x2029BD0
	private void <Start>b__22_1(AssetHandle<GameObject> handle) { }
}

public class SoilStatus : MonoBehaviour // TypeDefIndex: 10379
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1815D0 Offset: 0x1816D1 VA: 0x1815D0
	private bool <IsCultivated>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1815E0 Offset: 0x1816E1 VA: 0x1815E0
	private bool <IsWatering>k__BackingField; // 0x19
	private bool _nowCultivateStatus; // 0x1A
	private bool _nowWateringStatus; // 0x1B
	private GameObject _plowObj; // 0x20
	private GameObject _waterObj; // 0x28
	[SerializeField] // RVA: 0x1815F0 Offset: 0x1816F1 VA: 0x1815F0
	private GameObject _normalplowObj; // 0x30
	[SerializeField] // RVA: 0x181600 Offset: 0x181701 VA: 0x181600
	private GameObject _normalwaterObj; // 0x38
	[SerializeField] // RVA: 0x181610 Offset: 0x181711 VA: 0x181610
	private GameObject _largeplowObj; // 0x40
	[SerializeField] // RVA: 0x181620 Offset: 0x181721 VA: 0x181620
	private GameObject _largewaterObj; // 0x48
	private GameObject _focusObj; // 0x50
	private GameObject _focusObj2; // 0x58
	private int initialized; // 0x60
	private bool isLargeSoilSize; // 0x64
	private bool updateSoilSize; // 0x65

	// Properties
	public bool IsCultivated { get; set; }
	public bool IsWatering { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AED90 Offset: 0x1AEE91 VA: 0x1AED90
	// RVA: 0x20291D0 Offset: 0x20292D1 VA: 0x20291D0
	public bool get_IsCultivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDA0 Offset: 0x1AEEA1 VA: 0x1AEDA0
	// RVA: 0x20291E0 Offset: 0x20292E1 VA: 0x20291E0
	public void set_IsCultivated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDB0 Offset: 0x1AEEB1 VA: 0x1AEDB0
	// RVA: 0x20291F0 Offset: 0x20292F1 VA: 0x20291F0
	public bool get_IsWatering() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDC0 Offset: 0x1AEEC1 VA: 0x1AEDC0
	// RVA: 0x2029200 Offset: 0x2029301 VA: 0x2029200
	public void set_IsWatering(bool value) { }

	// RVA: 0x2029210 Offset: 0x2029311 VA: 0x2029210
	private void OnDestroy() { }

	// RVA: 0x2029360 Offset: 0x2029461 VA: 0x2029360
	private void Start() { }

	// RVA: 0x2029480 Offset: 0x2029581 VA: 0x2029480
	private void Update() { }

	// RVA: 0x20294B0 Offset: 0x20295B1 VA: 0x20294B0
	public void UpdateObj() { }

	// RVA: 0x20297C0 Offset: 0x20298C1 VA: 0x20297C0
	private void RemoveChildObjectsAll(Transform t) { }

	// RVA: 0x2029890 Offset: 0x2029991 VA: 0x2029890
	public void Focused(bool isFocus, bool isLarge = False) { }

	// RVA: 0x2029920 Offset: 0x2029A21 VA: 0x2029920
	public void ChangeSoilSize(bool isLarge) { }

	// RVA: 0x20295A0 Offset: 0x20296A1 VA: 0x20295A0
	private void UpdateSoilSize() { }

	// RVA: 0x20297B0 Offset: 0x20298B1 VA: 0x20297B0
	private bool Initialized() { }

	// RVA: 0x2029940 Offset: 0x2029A41 VA: 0x2029940
	public void ChangeCursorColor(bool isOk) { }

	// RVA: 0x2029A90 Offset: 0x2029B91 VA: 0x2029A90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDD0 Offset: 0x1AEED1 VA: 0x1AEDD0
	// RVA: 0x2029AA0 Offset: 0x2029BA1 VA: 0x2029AA0
	private void <Start>b__22_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDE0 Offset: 0x1AEEE1 VA: 0x1AEDE0
	// RVA: 0x2029BD0 Offset: 0x2029CD1 VA: 0x2029BD0
	private void <Start>b__22_1(AssetHandle<GameObject> handle) { }
}

public class SoilStatus : MonoBehaviour // TypeDefIndex: 10379
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1815D0 Offset: 0x1816D1 VA: 0x1815D0
	private bool <IsCultivated>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1815E0 Offset: 0x1816E1 VA: 0x1815E0
	private bool <IsWatering>k__BackingField; // 0x19
	private bool _nowCultivateStatus; // 0x1A
	private bool _nowWateringStatus; // 0x1B
	private GameObject _plowObj; // 0x20
	private GameObject _waterObj; // 0x28
	[SerializeField] // RVA: 0x1815F0 Offset: 0x1816F1 VA: 0x1815F0
	private GameObject _normalplowObj; // 0x30
	[SerializeField] // RVA: 0x181600 Offset: 0x181701 VA: 0x181600
	private GameObject _normalwaterObj; // 0x38
	[SerializeField] // RVA: 0x181610 Offset: 0x181711 VA: 0x181610
	private GameObject _largeplowObj; // 0x40
	[SerializeField] // RVA: 0x181620 Offset: 0x181721 VA: 0x181620
	private GameObject _largewaterObj; // 0x48
	private GameObject _focusObj; // 0x50
	private GameObject _focusObj2; // 0x58
	private int initialized; // 0x60
	private bool isLargeSoilSize; // 0x64
	private bool updateSoilSize; // 0x65

	// Properties
	public bool IsCultivated { get; set; }
	public bool IsWatering { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AED90 Offset: 0x1AEE91 VA: 0x1AED90
	// RVA: 0x20291D0 Offset: 0x20292D1 VA: 0x20291D0
	public bool get_IsCultivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDA0 Offset: 0x1AEEA1 VA: 0x1AEDA0
	// RVA: 0x20291E0 Offset: 0x20292E1 VA: 0x20291E0
	public void set_IsCultivated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDB0 Offset: 0x1AEEB1 VA: 0x1AEDB0
	// RVA: 0x20291F0 Offset: 0x20292F1 VA: 0x20291F0
	public bool get_IsWatering() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDC0 Offset: 0x1AEEC1 VA: 0x1AEDC0
	// RVA: 0x2029200 Offset: 0x2029301 VA: 0x2029200
	public void set_IsWatering(bool value) { }

	// RVA: 0x2029210 Offset: 0x2029311 VA: 0x2029210
	private void OnDestroy() { }

	// RVA: 0x2029360 Offset: 0x2029461 VA: 0x2029360
	private void Start() { }

	// RVA: 0x2029480 Offset: 0x2029581 VA: 0x2029480
	private void Update() { }

	// RVA: 0x20294B0 Offset: 0x20295B1 VA: 0x20294B0
	public void UpdateObj() { }

	// RVA: 0x20297C0 Offset: 0x20298C1 VA: 0x20297C0
	private void RemoveChildObjectsAll(Transform t) { }

	// RVA: 0x2029890 Offset: 0x2029991 VA: 0x2029890
	public void Focused(bool isFocus, bool isLarge = False) { }

	// RVA: 0x2029920 Offset: 0x2029A21 VA: 0x2029920
	public void ChangeSoilSize(bool isLarge) { }

	// RVA: 0x20295A0 Offset: 0x20296A1 VA: 0x20295A0
	private void UpdateSoilSize() { }

	// RVA: 0x20297B0 Offset: 0x20298B1 VA: 0x20297B0
	private bool Initialized() { }

	// RVA: 0x2029940 Offset: 0x2029A41 VA: 0x2029940
	public void ChangeCursorColor(bool isOk) { }

	// RVA: 0x2029A90 Offset: 0x2029B91 VA: 0x2029A90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDD0 Offset: 0x1AEED1 VA: 0x1AEDD0
	// RVA: 0x2029AA0 Offset: 0x2029BA1 VA: 0x2029AA0
	private void <Start>b__22_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDE0 Offset: 0x1AEEE1 VA: 0x1AEDE0
	// RVA: 0x2029BD0 Offset: 0x2029CD1 VA: 0x2029BD0
	private void <Start>b__22_1(AssetHandle<GameObject> handle) { }
}

