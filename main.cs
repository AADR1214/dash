using System;

public void speedUp = 0.25f

void MyInput()
{
  if (Input.GetKeyDown(KeyCode.r))
  {
    rb.AddForce Vector3.forward * speedUp * 2f;
  }
}