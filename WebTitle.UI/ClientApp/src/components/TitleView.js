import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import * as searchActions from '../store/actions/searchActions';
import PropTypes from 'prop-types';



class TitleView extends React.Component {

    componentDidMount(nextProps) {
      // This method runs when incoming props (e.g., route params) change
      const titleId = parseInt(nextProps.match.params.titleId) || 0;
      if (titleId > 0){
        this.props.actions.loadSingleTitle(titleId);
      }
      
    }


  render(){
    return (

      <div>
        <h2>{this.props.title.tileName}</h2>

        <h5> Release Year {this.props.title.releaseYear}</h5>


      </div>
    );
  }
}

TitleView.propTypes = {
  titleId: PropTypes.number.isRequired,
  title: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
}

TitleView.defaultProps = {
  titleId: 0,
  title: {},
  actions: {}
}

function mapStateToProps(state, ownProps){

  return {
    titleId: state.titleId
  };
}

function mapDispatchToProps(dispatch) {
  return {

    actions: bindActionCreators(searchActions, dispatch)

  };
}


export default connect(
  mapStateToProps,
  mapDispatchToProps
  
  )(TitleView);

