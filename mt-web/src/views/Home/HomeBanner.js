import React from "react";
import "../../styles/banner.scss";
import banner1 from "../../assets/images/banner/home/banner-1.jpg";
import banner2 from "../../assets/images/banner/home/banner-2.jpg";
import banner3 from "../../assets/images/banner/home/banner-3.jpg";

class HomeBanner extends React.Component {
  render() {
    return (
      <div className="div__home--banner">
        <div className="container">
          <img className="img__banner--item" src={banner1} alt="Banner 1" />
        </div>
      </div>
    );
  }
}

export default HomeBanner;
