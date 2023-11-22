namespace YourEngine
{
    /// <summary>
    /// You will have to program this yourself if you want a camera.
    /// Just know that GameObject.cs and Sprite.cs are already designed
    /// to take scrolling into account (study the code)!
    /// </summary>
    public class Camera // Hmm... does it have to inherit from GameObject or not (genuine question)?
    {
        public Camera() : base()
        {
        }

        // Hmm... static or not static? And why (most important)? !PERSONAL OPINION!: not static ;-)!
        // Hmm... how will the camera affect all GameObject instances in your game?
        // Hmm... so much to think about.
        // Designing programs is so fun (genuinely)!
    }
}
