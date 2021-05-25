public class RopeMaxTensionHandler : MonoBehaviour // TypeDefIndex: 9057
{
	// Fields
	[SerializeField] // RVA: 0x175C00 Offset: 0x175D01 VA: 0x175C00
	private float _lengthThreshold; // 0x18
	[SerializeField] // RVA: 0x175C10 Offset: 0x175D11 VA: 0x175C10
	public string _maxTensionStartCallMethod; // 0x20
	[SerializeField] // RVA: 0x175C20 Offset: 0x175D21 VA: 0x175C20
	public string _maxTensionEndCallMethod; // 0x28
	[SerializeField] // RVA: 0x175C30 Offset: 0x175D31 VA: 0x175C30
	public string _maxTensionContinueCallMethod; // 0x30
	[SerializeField] // RVA: 0x175C40 Offset: 0x175D41 VA: 0x175C40
	public GameObject _eventCallGameObject; // 0x38
	[SerializeField] // RVA: 0x175C50 Offset: 0x175D51 VA: 0x175C50
	public bool _fixHaywire; // 0x40
	[SerializeField] // RVA: 0x175C60 Offset: 0x175D61 VA: 0x175C60
	public bool _makeEndDynamicOnMaxTension; // 0x41
	private UltimateRope _rope; // 0x48
	private bool _started; // 0x50
	private bool _dynamicEnd; // 0x51

	// Methods

	// RVA: 0x1D68540 Offset: 0x1D68641 VA: 0x1D68540
	private void Start() { }

	// RVA: 0x1D685B0 Offset: 0x1D686B1 VA: 0x1D685B0
	private void LateUpdate() { }

	// RVA: 0x1D68FB0 Offset: 0x1D690B1 VA: 0x1D68FB0
	private void FixedUpdate() { }

	// RVA: 0x1D68B30 Offset: 0x1D68C31 VA: 0x1D68B30
	private void FixHaywire() { }

	// RVA: 0x1D68FD0 Offset: 0x1D690D1 VA: 0x1D68FD0
	public void .ctor() { }
}

