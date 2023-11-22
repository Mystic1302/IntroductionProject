using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using YourEngine;

namespace YourGame.Objects
{
    /// <summary>
    /// Just know that the player looks like a tree in this example.
    /// </summary>
    public sealed class Player : GameObject
    {
        public Player() : base()
        {
            this.Velocity = 64;

            this.Sprite = new Sprite(YourGame.AssetManager.LoadTexture("TX Plant", "Pixel Art Top Down - Basic/"))
            {
                SourceRectangle = new Rectangle(location: Point.Zero, size: new Point(160, 153)),
                OriginType = OriginType.BottomCenter,
            };

            this.AddChild(this.Sprite);
        }

        public Sprite Sprite { get; }

        protected override void EnterSelf()
        {
            //
        }

        protected override void UpdateSelf(GameTime gameTime)
        {
            // Update direction (standard 8-way movement code).
            Vector2 direction = Vector2.Zero;

            if (YourGame.InputManager.CheckIsKeyPressed(Keys.W))
                direction -= Vector2.UnitY;

            if (YourGame.InputManager.CheckIsKeyPressed(Keys.A))
                direction -= Vector2.UnitX;

            if (YourGame.InputManager.CheckIsKeyPressed(Keys.S))
                direction += Vector2.UnitY;

            if (YourGame.InputManager.CheckIsKeyPressed(Keys.D))
                direction += Vector2.UnitX;

            this.Direction = direction;

            // Update angle.
            this.Sprite.AngleDegrees = YourMath.Sine(
                elapsedTime: gameTime.TotalGameTimeInSeconds(),
                amplitude: 11.25f,
                period: 3
                );

            // Update scale.
            this.Sprite.Scale = new Vector2(YourMath.Sine(
                elapsedTime: gameTime.TotalGameTimeInSeconds(),
                amplitude: 1.25f,
                period: 3
                ).Clamp(1, 1.25f));
        }

        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            //
        }

        protected override void ExitSelf()
        {
            //
        }
    }
}
