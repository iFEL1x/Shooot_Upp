namespace CodeBase.Player
{
    public class ControlRotation : ControlHeight
    {
        public float MaxAngularVelocity { get; set; }

        protected override void FixedUpdate()
        {
            base.FixedUpdate();
            ControlAngleRotation();
        }

        private void ControlAngleRotation()
        {
            if (GumRigidbody.angularVelocity < -MaxAngularVelocity 
                || GumRigidbody.angularVelocity > MaxAngularVelocity)
                GumRigidbody.angularVelocity *= 0.5f;
        }
    }
}
