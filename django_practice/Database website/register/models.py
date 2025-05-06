from django.db import models

# Create your models here.
class RegisteredUser(models.Model):
    username = models.CharField(max_length=150)
    email = models.EmailField(unique=True)
    registration_date = models.DateTimeField(auto_now_add=True)