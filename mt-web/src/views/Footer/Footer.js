import React from "react";

class Footer extends React.Component {
  compName = "Cty TNHH Thương mại Phát triển Minh Thắng";
  compAdd = "283 Cách Mạng Tháng 8, Phường 12, Quận 10";
  compPhone = "0939042082";
  compPhoneText = "0939 042 082";
  compMail = "minhthangdevtrading@gmail.com";
  render() {
    return (
      <div className="block__footer">
        <div className="container">
          <aside className="aside__footer">
            <div className="block__footer--left col-12 col-sm-6 col-lg-3">
              <div className="block__about">
                <a href="https://makagarden.vn/" className="a__about">
                  <img
                    src="https://makagarden.vn/wp-content/uploads/2020/05/makagarden-logo.png"
                    alt={this.compName}
                    title={this.compName}
                  />
                </a>
                <p className="p__about">
                  Cung cấp các loại phân bón, thiết bị nông nghiệp nhập khẩu.
                  Giúp khách hàng chăm sóc khu vườn của mình một cách hạnh phúc
                  và dễ dàng hơn.
                </p>
                <p className="p__detail">
                  <span className="p__detail--name">{this.compName}</span>
                  <span className="p__detail--address">
                    <i className="fa fa-location-arrow"></i>
                    {this.compAdd}
                  </span>
                  <span className="p__detail--phone">
                    <i className="fa fa-mobile"></i>
                    Phone:{" "}
                    <a href={"tel:" + this.compPhoneText}>
                      {this.compPhoneText}
                    </a>
                  </span>
                  <span className="p__detail--mail">
                    <i className="fa fa-envelope-o"></i>
                    Mail:{" "}
                    <a href={"mailto:" + this.compMail}>{this.compMail}</a>
                  </span>
                </p>
                <p className="p__detail--worktime">
                  <h5>Thời gian làm việc</h5>
                  <span>
                    Thứ 2 - Thứ 6: Từ 8h00 - 17h00 <br />
                    Thứ 7: Từ 8h00 - 12h00 <br />
                    Chủ nhật: Nghỉ <br />
                  </span>
                </p>
              </div>
            </div>
            <div className="block__footer--center col-12 col-sm-6 col-lg-3">
              <div className="block__about--page">
                <h2>Giới thiệu</h2>
                <div className="block__about--page">
                  <ul>
                    <li>
                      <a>Giới thiệu MinhThangGroup</a>
                    </li>
                    <li>
                      <a>Tuyển dụng cộng tác viên, đại lý</a>
                    </li>
                    <li>
                      <a>Thông tin liên hệ</a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <div className="block__footer--right col-12 col-sm-6 col-lg-3">
              <div className="block__about--page">
                <h2>Hướng dẫn & Chính sách</h2>
                <div className="block__about--page">
                  <ul>
                    <li>
                      <a>Chính sách và quy định chung</a>
                    </li>
                    <li>
                      <a>Chính sách vận chuyển và thanh toán</a>
                    </li>
                    <li>
                      <a>Chính sách bảo hành, đổi trả</a>
                    </li>
                    <li>
                      <a>Chính sách bảo mật</a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
          </aside>

          <aside className="aside__copyright">
            <div className="block__footer--left col-12 col-sm-6 col-lg-3">
              <a href="/">
                <i className="fa fa-copyright"></i>
                Bản quyền thuộc về <b>MinhThangGroup</b> - Cty TNHH TMPT Minh
                Thắng
              </a>
            </div>
          </aside>
        </div>
      </div>
    );
  }
}

export default Footer;
