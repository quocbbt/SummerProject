import React from "react";
import ReactDOM from "react-dom/client";
import SummerProject from "./views/SummerProject";
import reportWebVitals from "./reportWebVitals";
import "./assets/fonts/woodmart.woff2";
import "./styles/global.scss";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <SummerProject />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
