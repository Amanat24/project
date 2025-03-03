// Smooth Scrolling
document.querySelectorAll('a[data-scroll]').forEach(anchor => {
  anchor.addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector(this.getAttribute('href')).scrollIntoView({
      behavior: 'smooth'
    });
  });
});

// Sticky Navbar
window.addEventListener('scroll', function () {
  const navbar = document.getElementById('navbar');
  if (window.scrollY > 50) {
    navbar.classList.add('sticky');
  } else {
    navbar.classList.remove('sticky');
  }
});

// Form Validation
document.querySelector('form').addEventListener('submit', function (e) {
  const email = document.querySelector('input[type="email"]').value;
  if (!email || !email.includes('@')) {
    e.preventDefault();
    alert('Please enter a valid email address.');
  }
});

// Back to Top Button
window.addEventListener('scroll', function () {
  const backToTopButton = document.getElementById('back-to-top');
  if (window.scrollY > 300) {
    backToTopButton.style.display = 'block';
  } else {
    backToTopButton.style.display = 'none';
  }
});

document.getElementById('back-to-top').addEventListener('click', function () {
  window.scrollTo({
    top: 0,
    behavior: 'smooth'
  });
});
