[RequireComponent] // RVA: 0xE1300 Offset: 0xE1401 VA: 0xE1300
[NativeClassAttribute] // RVA: 0xE1300 Offset: 0xE1401 VA: 0xE1300
[NativeHeaderAttribute] // RVA: 0xE1300 Offset: 0xE1401 VA: 0xE1300
public class Joint : Component // TypeDefIndex: 3436
{
	// Properties
	public Rigidbody connectedBody { get; set; }
	public Vector3 axis { set; }
	public Vector3 anchor { set; }
	public Vector3 connectedAnchor { set; }
	public float breakForce { set; }
	public float breakTorque { set; }

	// Methods

	// RVA: 0x350C9F0 Offset: 0x350CAF1 VA: 0x350C9F0
	public Rigidbody get_connectedBody() { }

	// RVA: 0x350CA40 Offset: 0x350CB41 VA: 0x350CA40
	public void set_connectedBody(Rigidbody value) { }

	// RVA: 0x350CA90 Offset: 0x350CB91 VA: 0x350CA90
	public void set_axis(Vector3 value) { }

	// RVA: 0x350CB40 Offset: 0x350CC41 VA: 0x350CB40
	public void set_anchor(Vector3 value) { }

	// RVA: 0x350CBF0 Offset: 0x350CCF1 VA: 0x350CBF0
	public void set_connectedAnchor(Vector3 value) { }

	// RVA: 0x350CCA0 Offset: 0x350CDA1 VA: 0x350CCA0
	public void set_breakForce(float value) { }

	// RVA: 0x350CCF0 Offset: 0x350CDF1 VA: 0x350CCF0
	public void set_breakTorque(float value) { }

	// RVA: 0x350CAF0 Offset: 0x350CBF1 VA: 0x350CAF0
	private void set_axis_Injected(ref Vector3 value) { }

	// RVA: 0x350CBA0 Offset: 0x350CCA1 VA: 0x350CBA0
	private void set_anchor_Injected(ref Vector3 value) { }

	// RVA: 0x350CC50 Offset: 0x350CD51 VA: 0x350CC50
	private void set_connectedAnchor_Injected(ref Vector3 value) { }
}

