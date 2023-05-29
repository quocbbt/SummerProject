import "./SummerProject.scss";
import "../styles/masterpage.scss";
import Header from "./Header/Header";
import Footer from "./Footer/Footer";

function SummerProject() {
  return (
    <div className="summerproject">
      <header className="summerproject-header">
        <Header />
      </header>

      <footer className="summerproject-footer">
        <Footer />
      </footer>
    </div>
  );
}

export default SummerProject;
