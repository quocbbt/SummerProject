import "./SummerProject.scss";
import "../styles/masterpage.scss";
import Header from "./Header/Header";
import Footer from "./Footer/Footer";
import Home from "./Home/Home";
import HomeBanner from "./Home/HomeBanner";

function SummerProject() {
  return (
    <div className="summerproject">
      <header className="summerproject-header">
        <Header />
      </header>
      <HomeBanner />
      <Home />
      <footer className="summerproject-footer">
        <Footer />
      </footer>
    </div>
  );
}

export default SummerProject;
