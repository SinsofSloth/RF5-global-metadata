[RequireComponent] // RVA: 0x148320 Offset: 0x148421 VA: 0x148320
public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 9403
{
	// Fields
	[TooltipAttribute] // RVA: 0x178BA0 Offset: 0x178CA1 VA: 0x178BA0
	public CameraController cameraController; // 0x18
	[TooltipAttribute] // RVA: 0x178BE0 Offset: 0x178CE1 VA: 0x178BE0
	public float accelerationTime; // 0x20
	[TooltipAttribute] // RVA: 0x178C20 Offset: 0x178D21 VA: 0x178C20
	public float turnTime; // 0x24
	[TooltipAttribute] // RVA: 0x178C60 Offset: 0x178D61 VA: 0x178C60
	public bool walkByDefault; // 0x28
	[TooltipAttribute] // RVA: 0x178CA0 Offset: 0x178DA1 VA: 0x178CA0
	public SimpleLocomotion.RotationMode rotationMode; // 0x2C
	[TooltipAttribute] // RVA: 0x178CE0 Offset: 0x178DE1 VA: 0x178CE0
	public float moveSpeed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x178D20 Offset: 0x178E21 VA: 0x178D20
	private bool <isGrounded>k__BackingField; // 0x34
	private Animator animator; // 0x38
	private float speed; // 0x40
	private float angleVel; // 0x44
	private float speedVel; // 0x48
	private Vector3 linearTargetDirection; // 0x4C
	private CharacterController characterController; // 0x58

	// Properties
	public bool isGrounded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1D0 Offset: 0x1AA2D1 VA: 0x1AA1D0
	// RVA: 0x272A2E0 Offset: 0x272A3E1 VA: 0x272A2E0
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA1E0 Offset: 0x1AA2E1 VA: 0x1AA1E0
	// RVA: 0x272A2F0 Offset: 0x272A3F1 VA: 0x272A2F0
	private void set_isGrounded(bool value) { }

	// RVA: 0x272A300 Offset: 0x272A401 VA: 0x272A300
	private void Start() { }

	// RVA: 0x272A3A0 Offset: 0x272A4A1 VA: 0x272A3A0
	private void Update() { }

	// RVA: 0x272AB30 Offset: 0x272AC31 VA: 0x272AB30
	private void LateUpdate() { }

	// RVA: 0x272A400 Offset: 0x272A501 VA: 0x272A400
	private void Rotate() { }

	// RVA: 0x272A880 Offset: 0x272A981 VA: 0x272A880
	private void Move() { }

	// RVA: 0x272AB70 Offset: 0x272AC71 VA: 0x272AB70
	private Vector3 GetInputVector() { }

	// RVA: 0x272AC70 Offset: 0x272AD71 VA: 0x272AC70
	private Vector3 GetInputVectorRaw() { }

	// RVA: 0x272AD10 Offset: 0x272AE11 VA: 0x272AD10
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x148320 Offset: 0x148421 VA: 0x148320
public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 9403
{
	// Fields
	[TooltipAttribute] // RVA: 0x178BA0 Offset: 0x178CA1 VA: 0x178BA0
	public CameraController cameraController; // 0x18
	[TooltipAttribute] // RVA: 0x178BE0 Offset: 0x178CE1 VA: 0x178BE0
	public float accelerationTime; // 0x20
	[TooltipAttribute] // RVA: 0x178C20 Offset: 0x178D21 VA: 0x178C20
	public float turnTime; // 0x24
	[TooltipAttribute] // RVA: 0x178C60 Offset: 0x178D61 VA: 0x178C60
	public bool walkByDefault; // 0x28
	[TooltipAttribute] // RVA: 0x178CA0 Offset: 0x178DA1 VA: 0x178CA0
	public SimpleLocomotion.RotationMode rotationMode; // 0x2C
	[TooltipAttribute] // RVA: 0x178CE0 Offset: 0x178DE1 VA: 0x178CE0
	public float moveSpeed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x178D20 Offset: 0x178E21 VA: 0x178D20
	private bool <isGrounded>k__BackingField; // 0x34
	private Animator animator; // 0x38
	private float speed; // 0x40
	private float angleVel; // 0x44
	private float speedVel; // 0x48
	private Vector3 linearTargetDirection; // 0x4C
	private CharacterController characterController; // 0x58

	// Properties
	public bool isGrounded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1D0 Offset: 0x1AA2D1 VA: 0x1AA1D0
	// RVA: 0x272A2E0 Offset: 0x272A3E1 VA: 0x272A2E0
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA1E0 Offset: 0x1AA2E1 VA: 0x1AA1E0
	// RVA: 0x272A2F0 Offset: 0x272A3F1 VA: 0x272A2F0
	private void set_isGrounded(bool value) { }

	// RVA: 0x272A300 Offset: 0x272A401 VA: 0x272A300
	private void Start() { }

	// RVA: 0x272A3A0 Offset: 0x272A4A1 VA: 0x272A3A0
	private void Update() { }

	// RVA: 0x272AB30 Offset: 0x272AC31 VA: 0x272AB30
	private void LateUpdate() { }

	// RVA: 0x272A400 Offset: 0x272A501 VA: 0x272A400
	private void Rotate() { }

	// RVA: 0x272A880 Offset: 0x272A981 VA: 0x272A880
	private void Move() { }

	// RVA: 0x272AB70 Offset: 0x272AC71 VA: 0x272AB70
	private Vector3 GetInputVector() { }

	// RVA: 0x272AC70 Offset: 0x272AD71 VA: 0x272AC70
	private Vector3 GetInputVectorRaw() { }

	// RVA: 0x272AD10 Offset: 0x272AE11 VA: 0x272AD10
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x148320 Offset: 0x148421 VA: 0x148320
public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 9403
{
	// Fields
	[TooltipAttribute] // RVA: 0x178BA0 Offset: 0x178CA1 VA: 0x178BA0
	public CameraController cameraController; // 0x18
	[TooltipAttribute] // RVA: 0x178BE0 Offset: 0x178CE1 VA: 0x178BE0
	public float accelerationTime; // 0x20
	[TooltipAttribute] // RVA: 0x178C20 Offset: 0x178D21 VA: 0x178C20
	public float turnTime; // 0x24
	[TooltipAttribute] // RVA: 0x178C60 Offset: 0x178D61 VA: 0x178C60
	public bool walkByDefault; // 0x28
	[TooltipAttribute] // RVA: 0x178CA0 Offset: 0x178DA1 VA: 0x178CA0
	public SimpleLocomotion.RotationMode rotationMode; // 0x2C
	[TooltipAttribute] // RVA: 0x178CE0 Offset: 0x178DE1 VA: 0x178CE0
	public float moveSpeed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x178D20 Offset: 0x178E21 VA: 0x178D20
	private bool <isGrounded>k__BackingField; // 0x34
	private Animator animator; // 0x38
	private float speed; // 0x40
	private float angleVel; // 0x44
	private float speedVel; // 0x48
	private Vector3 linearTargetDirection; // 0x4C
	private CharacterController characterController; // 0x58

	// Properties
	public bool isGrounded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1D0 Offset: 0x1AA2D1 VA: 0x1AA1D0
	// RVA: 0x272A2E0 Offset: 0x272A3E1 VA: 0x272A2E0
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA1E0 Offset: 0x1AA2E1 VA: 0x1AA1E0
	// RVA: 0x272A2F0 Offset: 0x272A3F1 VA: 0x272A2F0
	private void set_isGrounded(bool value) { }

	// RVA: 0x272A300 Offset: 0x272A401 VA: 0x272A300
	private void Start() { }

	// RVA: 0x272A3A0 Offset: 0x272A4A1 VA: 0x272A3A0
	private void Update() { }

	// RVA: 0x272AB30 Offset: 0x272AC31 VA: 0x272AB30
	private void LateUpdate() { }

	// RVA: 0x272A400 Offset: 0x272A501 VA: 0x272A400
	private void Rotate() { }

	// RVA: 0x272A880 Offset: 0x272A981 VA: 0x272A880
	private void Move() { }

	// RVA: 0x272AB70 Offset: 0x272AC71 VA: 0x272AB70
	private Vector3 GetInputVector() { }

	// RVA: 0x272AC70 Offset: 0x272AD71 VA: 0x272AC70
	private Vector3 GetInputVectorRaw() { }

	// RVA: 0x272AD10 Offset: 0x272AE11 VA: 0x272AD10
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x148320 Offset: 0x148421 VA: 0x148320
public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 9403
{
	// Fields
	[TooltipAttribute] // RVA: 0x178BA0 Offset: 0x178CA1 VA: 0x178BA0
	public CameraController cameraController; // 0x18
	[TooltipAttribute] // RVA: 0x178BE0 Offset: 0x178CE1 VA: 0x178BE0
	public float accelerationTime; // 0x20
	[TooltipAttribute] // RVA: 0x178C20 Offset: 0x178D21 VA: 0x178C20
	public float turnTime; // 0x24
	[TooltipAttribute] // RVA: 0x178C60 Offset: 0x178D61 VA: 0x178C60
	public bool walkByDefault; // 0x28
	[TooltipAttribute] // RVA: 0x178CA0 Offset: 0x178DA1 VA: 0x178CA0
	public SimpleLocomotion.RotationMode rotationMode; // 0x2C
	[TooltipAttribute] // RVA: 0x178CE0 Offset: 0x178DE1 VA: 0x178CE0
	public float moveSpeed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x178D20 Offset: 0x178E21 VA: 0x178D20
	private bool <isGrounded>k__BackingField; // 0x34
	private Animator animator; // 0x38
	private float speed; // 0x40
	private float angleVel; // 0x44
	private float speedVel; // 0x48
	private Vector3 linearTargetDirection; // 0x4C
	private CharacterController characterController; // 0x58

	// Properties
	public bool isGrounded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1D0 Offset: 0x1AA2D1 VA: 0x1AA1D0
	// RVA: 0x272A2E0 Offset: 0x272A3E1 VA: 0x272A2E0
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA1E0 Offset: 0x1AA2E1 VA: 0x1AA1E0
	// RVA: 0x272A2F0 Offset: 0x272A3F1 VA: 0x272A2F0
	private void set_isGrounded(bool value) { }

	// RVA: 0x272A300 Offset: 0x272A401 VA: 0x272A300
	private void Start() { }

	// RVA: 0x272A3A0 Offset: 0x272A4A1 VA: 0x272A3A0
	private void Update() { }

	// RVA: 0x272AB30 Offset: 0x272AC31 VA: 0x272AB30
	private void LateUpdate() { }

	// RVA: 0x272A400 Offset: 0x272A501 VA: 0x272A400
	private void Rotate() { }

	// RVA: 0x272A880 Offset: 0x272A981 VA: 0x272A880
	private void Move() { }

	// RVA: 0x272AB70 Offset: 0x272AC71 VA: 0x272AB70
	private Vector3 GetInputVector() { }

	// RVA: 0x272AC70 Offset: 0x272AD71 VA: 0x272AC70
	private Vector3 GetInputVectorRaw() { }

	// RVA: 0x272AD10 Offset: 0x272AE11 VA: 0x272AD10
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x148320 Offset: 0x148421 VA: 0x148320
public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 9403
{
	// Fields
	[TooltipAttribute] // RVA: 0x178BA0 Offset: 0x178CA1 VA: 0x178BA0
	public CameraController cameraController; // 0x18
	[TooltipAttribute] // RVA: 0x178BE0 Offset: 0x178CE1 VA: 0x178BE0
	public float accelerationTime; // 0x20
	[TooltipAttribute] // RVA: 0x178C20 Offset: 0x178D21 VA: 0x178C20
	public float turnTime; // 0x24
	[TooltipAttribute] // RVA: 0x178C60 Offset: 0x178D61 VA: 0x178C60
	public bool walkByDefault; // 0x28
	[TooltipAttribute] // RVA: 0x178CA0 Offset: 0x178DA1 VA: 0x178CA0
	public SimpleLocomotion.RotationMode rotationMode; // 0x2C
	[TooltipAttribute] // RVA: 0x178CE0 Offset: 0x178DE1 VA: 0x178CE0
	public float moveSpeed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x178D20 Offset: 0x178E21 VA: 0x178D20
	private bool <isGrounded>k__BackingField; // 0x34
	private Animator animator; // 0x38
	private float speed; // 0x40
	private float angleVel; // 0x44
	private float speedVel; // 0x48
	private Vector3 linearTargetDirection; // 0x4C
	private CharacterController characterController; // 0x58

	// Properties
	public bool isGrounded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1D0 Offset: 0x1AA2D1 VA: 0x1AA1D0
	// RVA: 0x272A2E0 Offset: 0x272A3E1 VA: 0x272A2E0
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA1E0 Offset: 0x1AA2E1 VA: 0x1AA1E0
	// RVA: 0x272A2F0 Offset: 0x272A3F1 VA: 0x272A2F0
	private void set_isGrounded(bool value) { }

	// RVA: 0x272A300 Offset: 0x272A401 VA: 0x272A300
	private void Start() { }

	// RVA: 0x272A3A0 Offset: 0x272A4A1 VA: 0x272A3A0
	private void Update() { }

	// RVA: 0x272AB30 Offset: 0x272AC31 VA: 0x272AB30
	private void LateUpdate() { }

	// RVA: 0x272A400 Offset: 0x272A501 VA: 0x272A400
	private void Rotate() { }

	// RVA: 0x272A880 Offset: 0x272A981 VA: 0x272A880
	private void Move() { }

	// RVA: 0x272AB70 Offset: 0x272AC71 VA: 0x272AB70
	private Vector3 GetInputVector() { }

	// RVA: 0x272AC70 Offset: 0x272AD71 VA: 0x272AC70
	private Vector3 GetInputVectorRaw() { }

	// RVA: 0x272AD10 Offset: 0x272AE11 VA: 0x272AD10
	public void .ctor() { }
}

