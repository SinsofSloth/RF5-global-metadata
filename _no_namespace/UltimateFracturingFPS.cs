public class UltimateFracturingFPS : MonoBehaviour // TypeDefIndex: 9027
{
	// Fields
	public UltimateFracturingFPS.Mode ShootMode; // 0x18
	public float MouseSpeed; // 0x1C
	public Texture HUDTexture; // 0x20
	public float HUDSize; // 0x28
	public Color HUDColorNormal; // 0x2C
	public Color HUDColorRaycast; // 0x3C
	public Transform Weapon; // 0x50
	public AudioClip AudioWeaponShot; // 0x58
	public float WeaponShotVolume; // 0x60
	public float ExplosionForce; // 0x64
	public float ExplosionRadius; // 0x68
	public float RecoilDuration; // 0x6C
	public float RecoilIntensity; // 0x70
	public GameObject ObjectToShoot; // 0x78
	public float InitialObjectSpeed; // 0x80
	public float ObjectScale; // 0x84
	public float ObjectMass; // 0x88
	public float ObjectLife; // 0x8C
	private Vector3 m_v3MousePosition; // 0x90
	private bool m_bRaycastFound; // 0x9C
	private float m_fRecoilTimer; // 0xA0
	private Vector3 m_v3InitialWeaponPos; // 0xA4
	private Quaternion m_qInitialWeaponRot; // 0xB0

	// Methods

	// RVA: 0x1F55AF0 Offset: 0x1F55BF1 VA: 0x1F55AF0
	private void Start() { }

	// RVA: 0x1F55BD0 Offset: 0x1F55CD1 VA: 0x1F55BD0
	private void OnGUI() { }

	// RVA: 0x1F55E20 Offset: 0x1F55F21 VA: 0x1F55E20
	private void Update() { }

	// RVA: 0x1F56650 Offset: 0x1F56751 VA: 0x1F56650
	public void .ctor() { }
}

