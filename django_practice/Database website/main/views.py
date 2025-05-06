from django.shortcuts import render
from django.http import HttpResponse, HttpResponseRedirect
from main.models import RegisteredUser

# Create your views here.

def index(response):
    return render(response, "main/home.html", {})

def home(response):
    return render(response, "main/home.html", {})

def table(request):
    users = RegisteredUser.objects.all()
    return render(request, "main/table.html", {"users": users})
