import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const TitleList = ({ titles }) => (
  <table className="table">
    <thead>
      <tr>
        <th>Title</th>
        <th>Release Year</th>
      </tr>
    </thead>
    <tbody>
      {titles.map(title => {
        return (
          <tr key={title.titleId}>
            <td>
              <Link to={"/title/" + title.titleId}>{title.titleName}</Link>
            </td>
            <td>({title.releaseYear})</td>
          </tr>
        );
      })}
    </tbody>
  </table>
);

TitleList.propTypes = {
  titles: PropTypes.array.isRequired,
};

export default TitleList;


