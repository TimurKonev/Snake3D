using UnityEngine;

static class ColorCheck
{
    public static bool IsEqualTo(this Color human, Color snake)
    {
        return human.r == snake.r && human.g == snake.g && human.b == snake.b && human.a == snake.a;
    }
}