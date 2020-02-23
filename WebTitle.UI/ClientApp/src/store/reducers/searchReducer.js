import * as types from '../actions/actionTypes';
import initialState from './initialState';



export const searchReducer = (state = initialState.searchCriteria, action) => {
  switch(action.type){
    case types.SEARCH_TITLE:
      return state;

    default:
      return state;
  }
}

export const titlesReducer = (state = initialState.titles, action) => {
  switch(action.type){

    case types.LOAD_TITLES_SUCCESS:
      return action.titles;

    default:
      return state;
  }
}

export const titleIdReducer = (state = initialState.titleId, action) => {
  switch(action.type){

    case types.LOAD_SINGLE_TITLE_SUCCESS:
      return action.titleId;
    default:
      return state;
  }
}

