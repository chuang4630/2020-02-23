import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

import * as searchActions from '../store/actions/searchActions';
import PropTypes from 'prop-types';
import TitleList from './TitleList';


class SearchTitle extends React.Component {
    state = {
      searchCriteria: {
        TitleName: ""
      }
    };

  handleChange = event => {
    const searchCriteria = { ...this.state.searchCriteria, TitleName: event.target.value };
    this.setState({searchCriteria})

    // if (this.state.title.TitleName.length > 3){
    //   fetch('http://localhost:5000/api/mediatitle/names/' + this.state.title.TitleName, {
    //     method: 'GET'
    //   })
    // }
  }

  handleSubmit = event => {
    event.preventDefault();
    this.props.actions.searchTitle(this.state.searchCriteria);
    // this.props.dispatch(searchActions.searchTitle(this.state.searchCriteria));
    // alert(this.state.searchCriteria.TitleName);
  }


  render(){
    return (
      <div>
        <div>
          <input  type="text"
          id="searchtitle"
          name="searchtitle"
            placeholder="Search title ..."
            onChange={ this.handleChange }
            value={this.state.searchCriteria.TitleName}
          />

        <button type="button" onClick={this.handleSubmit}>Search</button>
        </div>


      <br/>
      Found {this.props.titles.length} items
      <h4>Titles Found</h4>
      <TitleList titles={this.props.titles}/>
      </div>
    );
  }

}


SearchTitle.propTypes = {
  titles: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
}

SearchTitle.defaultProps = {
  titles: [],
  actions: {}
}

function mapStateToProps(state){
  return {
    titles: state.titles
  };
}

function mapDispatchToProps(dispatch) {
  return {
    // searchTitle: searchCriteria => dispatch(searchActions.searchTitle(searchCriteria))
    actions: bindActionCreators(searchActions, dispatch)

    // searchTitle: searchActions.searchTitle
  };
}


export default connect(
  mapStateToProps,
  mapDispatchToProps
  
  )(SearchTitle);

