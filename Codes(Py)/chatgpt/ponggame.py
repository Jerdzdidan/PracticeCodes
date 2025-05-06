import pygame
import random

# Initialize Pygame
pygame.init()

# Set up display
width, height = 800, 600
screen = pygame.display.set_mode((width, height))
pygame.display.set_caption("Pong Game")

# Colors
black = (0, 0, 0)
white = (255, 255, 255)

# Paddle settings
paddle_width = 15
paddle_height = 100
player_paddle = pygame.Rect(50, height//2 - paddle_height//2, paddle_width, paddle_height)
opponent_paddle = pygame.Rect(width - 50 - paddle_width, height//2 - paddle_height//2, paddle_width, paddle_height)

# Ball settings
ball = pygame.Rect(width//2 - 15, height//2 - 15, 30, 30)
ball_speed_x = 7 * random.choice((1, -1))
ball_speed_y = 7 * random.choice((1, -1))

# Score variables
player_score = 0
opponent_score = 0
font = pygame.font.Font(None, 36)

# Game loop
running = True
clock = pygame.time.Clock()

while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    keys = pygame.key.get_pressed()
    if keys[pygame.K_UP] and player_paddle.top > 0:
        player_paddle.y -= 5
    if keys[pygame.K_DOWN] and player_paddle.bottom < height:
        player_paddle.y += 5

    # Ball movement
    ball.x += ball_speed_x
    ball.y += ball_speed_y

    # Ball collisions
    if ball.top <= 0 or ball.bottom >= height:
        ball_speed_y *= -1

    if ball.colliderect(player_paddle) or ball.colliderect(opponent_paddle):
        ball_speed_x *= -1

    if ball.left <= 0:
        opponent_score += 1
        ball = pygame.Rect(width//2 - 15, height//2 - 15, 30, 30)
        ball_speed_x *= random.choice((1, -1))
        ball_speed_y *= random.choice((1, -1))

    if ball.right >= width:
        player_score += 1
        ball = pygame.Rect(width//2 - 15, height//2 - 15, 30, 30)
        ball_speed_x *= random.choice((1, -1))
        ball_speed_y *= random.choice((1, -1))

    # Draw everything
    screen.fill(black)
    pygame.draw.rect(screen, white, player_paddle)
    pygame.draw.rect(screen, white, opponent_paddle)
    pygame.draw.ellipse(screen, white, ball)
    player_text = font.render(f"Player: {player_score}", True, white)
    opponent_text = font.render(f"Opponent: {opponent_score}", True, white)
    screen.blit(player_text, (20, 20))
    screen.blit(opponent_text, (width - opponent_text.get_width() - 20, 20))

    pygame.display.flip()
    clock.tick(60)

pygame.quit()