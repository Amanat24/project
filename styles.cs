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
    transition: color 0.3s ease;
  }
  
  nav .menu a:hover {
    color: #f8f9fa;
  }
  
  /* Header Section */
  header {
    background: url('farm-background.jpg') no-repeat center center/cover;
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
    transition: background 0.3s ease;
    animation: fadeIn 3s ease-in-out;
  }
  
  .btn:hover {
    background: #218838;
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
  
  /* Footer Section */
  footer {
    background: #333;
    color: #fff;
    text-align: center;
    padding: 20px 0;
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
