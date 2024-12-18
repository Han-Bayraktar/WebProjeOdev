const showHiddenPass = (inputId, iconId) => {
    const input = document.getElementById(inputId),
        icon = document.getElementById(iconId);

    icon.addEventListener('click', () => {
        if (input.type === 'password') {
            input.type = 'text';
            icon.classList.add('ri-eye-line');
            icon.classList.remove('ri-eye-off-line');
        } else {
            input.type = 'password';
            icon.classList.remove('ri-eye-line');
            icon.classList.add('ri-eye-off-line');
        }
    });
};

showHiddenPass('login-pass', 'login-eye');
showHiddenPass('register-pass', 'register-eye');
