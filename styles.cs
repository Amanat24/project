
/* General Styles */
body {
  font-family: 'Roboto', sans-serif;
  margin: 0;
  padding: 0;
  line-height: 1.6;
  color: #333;
}

.container {
  width: 90%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 20px 0;
}

h1, h2, h3 {
  margin: 0;
}

/* Hero Slider */
#hero {
position: relative;
overflow: hidden;
height: 500px; 
}

.slider {
display: flex;
transition: transform 0.5s ease-in-out;
width: 100%;
height: 100%;
}

.slide {
min-width: 100%;
position: relative;
height: 100%;
}

.slide img {
width: 100%;
height: 100%;
object-fit: cover; 
}

.slide-content {
position: absolute;
top: 50%;
left: 50%;
transform: translate(-50%, -50%);
text-align: center;
color: #fff;
background: rgba(0, 0, 0, 0.5); 
padding: 20px;
border-radius: 10px;
}

.slide-content h2 {
font-size: 2.5rem;
margin-bottom: 10px;
}

.slide-content p {
font-size: 1.2rem;
margin-bottom: 20px;
}

.prev, .next {
position: absolute;
top: 50%;
transform: translateY(-50%);
background: rgba(0, 0, 0, 0.5);
color: #fff;
border: none;
padding: 10px 15px;
cursor: pointer;
font-size: 1.5rem;
border-radius: 50%;
z-index: 10;
}

.prev {
left: 20px;
}

.next {
right: 20px;
}

/* Fallback for non-JS users */
.slider {
display: block;
}

.slide {
display: none;
}

.slide.active {
display: block;
}

/* Menu Bar */
nav {
  background: #28a745;
  padding: 10px 0;
  position: sticky;
  top: 0;
  z-index: 1000;
  transition: background 0.3s ease;
}

nav.sticky {
  background: rgba(40, 167, 69, 0.9);
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
}

nav .container {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

nav .logo {
  color: #fff;
  font-size: 1.8rem;
  font-weight: bold;
}

nav .menu {
  list-style: none;
  margin: 0;
  padding: 0;
  display: flex;
}

nav .menu li {
  margin-left: 20px;
}

nav .menu a {
  color: #fff;
  text-decoration: none;
  font-size: 1.1rem;
  transition: color 0.3s ease, transform 0.3s ease;
}

nav .menu a:hover {
  color: #f8f9fa;
  transform: translateY(-2px);
}

/* Header Section */
header {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url('farm-background.jpg') no-repeat center center/cover;
  color: #fff;
  text-align: center;
  padding: 150px 0;
}

header h1 {
  font-size: 3rem;
  margin-bottom: 10px;
  animation: fadeIn 2s ease-in-out;
}

header p {
  font-size: 1.5rem;
  margin-bottom: 20px;
  animation: fadeIn 2.5s ease-in-out;
}

.btn {
  display: inline-block;
  padding: 10px 20px;
  background: #28a745;
  color: #fff;
  text-decoration: none;
  border-radius: 5px;
  font-size: 1.2rem;
  transition: background 0.3s ease, transform 0.3s ease;
}

.btn:hover {
  background: #218838;
  transform: scale(1.05);
}

/* About Section */
#about {
  background: #f8f9fa;
  padding: 50px 0;
  text-align: center;
}

#about h2 {
  font-size: 2.5rem;
  margin-bottom: 20px;
  animation: fadeIn 1s ease-in-out;
}

#about p {
  font-size: 1.2rem;
  max-width: 800px;
  margin: 0 auto;
  animation: fadeIn 1.5s ease-in-out;
}

/* Courses Section */
#courses {
  padding: 50px 0;
  text-align: center;
}

#courses h2 {
  font-size: 2.5rem;
  margin-bottom: 40px;
  animation: fadeIn 1s ease-in-out;
}

.course-list {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
}

.course {
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 5px;
  padding: 20px;
  width: 30%;
  margin-bottom: 20px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  transition: transform 0.3s ease, box-shadow 0.3s ease;
  animation: fadeIn 2s ease-in-out;
}

.course:hover {
  transform: translateY(-10px);
  box-shadow: 0 8px 12px rgba(0, 0, 0, 0.2);
}

.course h3 {
  font-size: 1.5rem;
  margin-bottom: 10px;
}

.course p {
  font-size: 1rem;
}

/* Blog Section */
#blogs {
  background: #f8f9fa;
  padding: 50px 0;
  text-align: center;
}

#blogs h2 {
  font-size: 2.5rem;
  margin-bottom: 40px;
  animation: fadeIn 1s ease-in-out;
}

.blog-list {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
}

.blog {
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  padding: 20px;
  width: 30%;
  margin-bottom: 20px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.blog:hover {
  transform: translateY(-10px);
  box-shadow: 0 8px 12px rgba(0, 0, 0, 0.2);
}

.blog h3 {
  font-size: 1.5rem;
  margin-bottom: 10px;
}

.blog p {
  font-size: 1rem;
  margin-bottom: 10px;
}

.blog a {
  color: #28a745;
  text-decoration: none;
  font-weight: bold;
}

.blog a:hover {
  text-decoration: underline;
}

.cta {
  margin-top: 20px;
}

.cta a {
  color: #28a745;
  text-decoration: none;
  font-weight: bold;
}

.cta a:hover {
  text-decoration: underline;
}

/* Call-to-Action Banner */
#cta-banner {
  background: linear-gradient(135deg, #28a745, #218838); 
  color: #fff;
  text-align: center;
  padding: 60px 0;
}

#cta-banner h2 {
  font-size: 2.5rem;
  margin-bottom: 10px;
  animation: fadeIn 1s ease-in-out;
}

#cta-banner p {
  font-size: 1.2rem;
  margin-bottom: 20px;
  animation: fadeIn 1.5s ease-in-out;
}

#cta-banner .btn {
  background: #fff; /* White button */
  color: #28a745; /* Green text */
  font-size: 1.2rem;
  padding: 10px 20px;
  border-radius: 5px;
  text-decoration: none;
  transition: background 0.3s ease, transform 0.3s ease;
}

#cta-banner .btn:hover {
  background: #f8f9fa; /* Light gray on hover */
  transform: scale(1.05);
}

/* Testimonials Section */
#testimonials {
  padding: 50px 0;
  text-align: center;
}

#testimonials h2 {
  font-size: 2.5rem;
  margin-bottom: 40px;
  animation: fadeIn 1s ease-in-out;
}

.testimonial-list {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
}

.testimonial {
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  padding: 20px;
  width: 45%;
  margin-bottom: 20px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
}

.testimonial p {
  font-size: 1.1rem;
  margin-bottom: 10px;
}

.testimonial h4 {
  font-size: 1.2rem;
  color: #28a745;
}

/* FAQ Section */
#faq {
  background: #f8f9fa;
  padding: 50px 0;
  text-align: center;
}

#faq h2 {
  font-size: 2.5rem;
  margin-bottom: 40px;
  animation: fadeIn 1s ease-in-out;
}

.faq-list {
  max-width: 800px;
  margin: 0 auto;
}

.faq-item {
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  margin-bottom: 15px;
  overflow: hidden;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  transition: box-shadow 0.3s ease;
}

.faq-item h3 {
  font-size: 1.2rem;
  margin: 0;
  padding: 15px 20px;
  cursor: pointer;
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #28a745;
  color: #fff;
}

.faq-item h3 span {
  font-size: 1.5rem;
}

.faq-item p {
  font-size: 1rem;
  padding: 0 20px 20px 20px;
  margin: 0;
  display: none;
}

.faq-item.active p {
  display: block;
}

.faq-item:hover {
  box-shadow: 0 8px 12px rgba(0, 0, 0, 0.2);
}

/* Contact Section */
#contact {
  background: #f8f9fa;
  padding: 50px 0;
  text-align: center;
}

#contact h2 {
  font-size: 2.5rem;
  margin-bottom: 20px;
  animation: fadeIn 1s ease-in-out;
}

#contact a {
  color: #28a745;
  text-decoration: none;
}

#contact a:hover {
  text-decoration: underline;
}

/* Subscription Section */
#subscribe {
  background: #fff;
  padding: 50px 0;
  text-align: center;
}

#subscribe h2 {
  font-size: 2.5rem;
  margin-bottom: 20px;
  animation: fadeIn 1s ease-in-out;
}

#subscribe input[type="email"] {
  padding: 10px;
  width: 300px;
  border: 1px solid #ddd;
  border-radius: 5px;
  margin-right: 10px;
}
#subscribe .btn {
  padding: 10px 20px;
}

#congrats-message {
  margin-top: 20px;
  padding: 15px;
  background: #28a745;
  color: #fff;
  border-radius: 5px;
  text-align: center;
  animation: fadeIn 1s ease-in-out;
}

@keyframes fadeIn {
  from {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}

/* Footer Section */
footer {
  background: #333;
  color: #fff;
  text-align: center;
  padding: 20px 0;
}

.social-media {
  margin-top: 10px;
}

.social-media a {
  color: #fff;
  text-decoration: none;
  margin: 0 10px;
}

.social-media a:hover {
  text-decoration: underline;
}

/* Back to Top Button */
#back-to-top {
  display: none;
  position: fixed;
  bottom: 20px;
  right: 20px;
  background: #28a745;
  color: #fff;
  border: none;
  border-radius: 50%;
  padding: 10px 15px;
  font-size: 1.2rem;
  cursor: pointer;
  transition: background 0.3s ease;
}

#back-to-top:hover {
  background: #218838;
}

/* Animations */
@keyframes fadeIn {
  from {
    opacity: 0;
    transform: translateY(20px);
  }
  to {
    opacity: 1;
    transform: translateY(0);
  }
}

/* Responsive Design */
@media (max-width: 768px) {
  .course, .blog, .testimonial {
    width: 100%;
    margin-bottom: 20px;
  }
  nav .menu {
    flex-direction: column;
    align-items: center;
  }
  header {
    padding: 100px 0;
  }
  header h1 {
    font-size: 2rem;
  }
  header p {
    font-size: 1.2rem;
  }
}

@media (max-width: 768px) {
  #hero {
    height: 300px; 
  }

  .slide-content h2 {
    font-size: 2rem;
  }

  .slide-content p {
    font-size: 1rem;
  }

  .prev, .next {
    padding: 8px 12px;
    font-size: 1.2rem;
  }
}
