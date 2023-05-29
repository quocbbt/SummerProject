import React, { Fragment } from "react";

class Header extends React.Component {
  state = {
    siteUrl: "http://localhost:3000/",
    searchText: "",
    cartCount: 0,
    cartTotal: 0,
  };

  onChangeSearchText = (event) => {
    this.setState({ searchText: event.target.value });
  };

  handleSubmit = (event) => {
    event.preventDefault();
    alert("Check data input");
  };

  render() {
    return (
      <Fragment>
        <div className="block__header">
          <div className="container">
            <div className="block__header--left block__header--visible__lg">
              <b>
                <span>Chào mừng bạn đến với SummerProject</span>
              </b>
            </div>
            <div className="block__header--center block__header--visible__lg" />
            <div className="block__header--right block__header--visible__lg">
              <a
                href="https://facebook.com/nguyenbaobt"
                target="_blank"
                rel="noopener noreferrer"
              >
                <span className="span__icon i-fb"></span>
              </a>
              <a
                href="https://www.youtube.com/"
                target="_blank"
                rel="noopener noreferrer"
              >
                <span className="span__icon i-yt"></span>
              </a>
            </div>
            <div className="block__header--center block__header--mobile block__header--hidden__lg">
              <a
                href="https://facebook.com/nguyenbaobt"
                target="_blank"
                rel="noopener noreferrer"
              >
                <span className="span__icon i-fb"></span>
              </a>
              <a
                href="https://www.youtube.com/"
                target="_blank"
                rel="noopener noreferrer"
              >
                <span className="span__icon i-yt"></span>
              </a>
            </div>
          </div>
        </div>
        <div className="block__search">
          <div className="container">
            <div className="block__header--left block__header--visible__lg">
              <div className="block__logo">
                <a href={this.state.siteUrl} rel="home">
                  <img
                    src="https://makagarden.vn/wp-content/uploads/2020/05/makagarden-logo.png"
                    alt="Maka Garden"
                  />
                </a>
              </div>
            </div>
            <div className="block__header--center block__header--visible__lg">
              <div className="block__form">
                <form>
                  <input
                    type="text"
                    className="input__searchText"
                    value={this.state.searchText}
                    placeholder="Nhập sản phẩm cần tìm"
                    onChange={(event) => this.onChangeSearchText(event)}
                  />
                  <button type="submit" className="btn__searchSubmit">
                    <span>Search</span>
                  </button>
                </form>
              </div>
            </div>
            <div className="block__header--right block__header--visible__lg">
              <a href="/login" className="link__login">
                <b>Đăng nhập CTV/Đại lý</b>
              </a>

              <a href="/cart" className="link__cart">
                <span className="span__icon">
                  <span className="span__count">{this.state.cartCount}</span>
                </span>
                <span className="span__total">{this.state.cartTotal}đ</span>
              </a>
            </div>
          </div>
        </div>
        <div className="block__menu">
          <div className="container">
            <div className="block__header--left block__header--visible__lg">
              <div className="block__menu--detail">
                <span className="span__menu--detail">
                  <span className="span__icon"></span>
                  <span className="span__text">Danh mục sản phẩm</span>
                </span>
                <div className="div__menu--dropdown">
                  <ul>
                    <li>
                      <a href="/phan-bon" className="a__category--expendable">
                        <img
                          className="img__category--icon"
                          src="https://makagarden.vn/wp-content/uploads/2020/10/phan-bon-icon.png"
                          data-src="https://makagarden.vn/wp-content/uploads/2020/10/phan-bon-icon.png"
                        />
                        <span className="span__category--name">Phân bón</span>
                      </a>
                      <div className="div__menu--child">
                        <ul>
                          <li>
                            <a href="/phan-bon-vi-sinh">
                              <span className="span__category--name">
                                Phân bón vi sinh
                              </span>
                            </a>
                          </li>
                          <li>
                            <a href="/phan-bon-huu-co">
                              <span className="span__category--name">
                                Phân bón hữu cơ
                              </span>
                            </a>
                          </li>
                          <li>
                            <a href="/phan-bon-vo-co">
                              <span className="span__category--name">
                                Phân bón vô cơ
                              </span>
                            </a>
                          </li>
                        </ul>
                      </div>
                    </li>
                    <li>
                      <a
                        href="/dat-trong-cay-gia-the"
                        className="a__category--expendable"
                      >
                        <img
                          className="img__category--icon"
                          src="https://makagarden.vn/wp-content/uploads/2020/10/dat-trong-cay-icon.png"
                          data-src="https://makagarden.vn/wp-content/uploads/2020/10/dat-trong-cay-icon.png"
                        />
                        <span className="span__category--name">
                          Đất trồng cây - Giá thể
                        </span>
                      </a>
                      <div className="div__menu--child">
                        <ul>
                          <li>
                            <a href="/dat-trong-hoa">
                              <span className="span__category--name">
                                Đất trồng hoa
                              </span>
                            </a>
                          </li>
                          <li>
                            <a href="/dat-trong-rau">
                              <span className="span__category--name">
                                Đất trồng rau
                              </span>
                            </a>
                          </li>
                          <li>
                            <a href="/dat-trong-sen-da-xuong-rong">
                              <span className="span__category--name">
                                Đất trồng sen đá và xương rồng
                              </span>
                            </a>
                          </li>
                          <li>
                            <a href="/gia-the">
                              <span className="span__category--name">
                                Giá thể
                              </span>
                            </a>
                          </li>
                          <li>
                            <a href="/da-perlite">
                              <span className="span__category--name">
                                Đá perlite
                              </span>
                            </a>
                          </li>
                        </ul>
                      </div>
                    </li>
                    <li>
                      <a
                        href="/hat-cay-giong"
                        className="a__category--expendable"
                      >
                        <img
                          className="img__category--icon"
                          src="https://makagarden.vn/wp-content/uploads/2020/10/hat-giong-icon.png"
                          data-src="https://makagarden.vn/wp-content/uploads/2020/10/hat-giong-icon.png"
                        />
                        <span className="span__category--name">
                          Hạt - cây giống
                        </span>
                      </a>
                    </li>
                    <li>
                      <a href="/hat-cay-giong">
                        <img
                          className="img__category--icon"
                          src="https://makagarden.vn/wp-content/uploads/2020/10/dung-cu-lam-vuon-icon.png"
                          data-src="https://makagarden.vn/wp-content/uploads/2020/10/dung-cu-lam-vuon-icon.png"
                        />
                        <span className="span__category--name">
                          Dụng cụ làm vườn
                        </span>
                      </a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <div className="block__header--center block__header--visible__lg">
              <div className="block__nav__link">
                <ul>
                  <li>
                    <a href="/" className="nav__link">
                      Trang chủ
                    </a>
                  </li>
                  <li>
                    <a href="/about" className="nav__link">
                      Giới thiệu
                    </a>
                  </li>
                  <li>
                    <a
                      href="/product"
                      className="nav__link nav__link--haschild"
                    >
                      Sản phẩm
                    </a>
                  </li>
                  <li>
                    <a href="/news" className="nav__link">
                      Tin tức - Sự kiện
                    </a>
                  </li>
                  <li>
                    <a href="/contact" className="nav__link">
                      Liên hệ
                    </a>
                  </li>
                </ul>
              </div>
            </div>
            <div className="block__header--right block__header--visible__lg" />
          </div>
        </div>
      </Fragment>
    );
  }
}

export default Header;
