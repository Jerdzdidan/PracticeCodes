from django.shortcuts import render, redirect
from .forms import RegisterForm
from main.models import RegisteredUser

def register(request):
    if request.method == "POST":
        form = RegisterForm(request.POST)
        if form.is_valid():
            form.save()
            RegisteredUser.objects.create(
                username=form.cleaned_data['username'],
                email=form.cleaned_data['email']
            )
            return redirect("/table")  
    else:
        form = RegisterForm()

    return render(request, "register/register.html", {"form": form})
