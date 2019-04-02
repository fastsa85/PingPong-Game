using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Tutorial_1
{
    public class Score
    {
        public int Score1;
        public int Score2;

        private SpriteFont _spriteFont;

        public Score(SpriteFont spriteFont)
        {
            _spriteFont = spriteFont;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_spriteFont, Score1.ToString(), new Vector2(320, 70), Color.White); //TODO: Remove hardcoede Position
            spriteBatch.DrawString(_spriteFont, Score2.ToString(), new Vector2(430, 70), Color.White); //TODO: Remove hardcoede Position
        }
    }
}
