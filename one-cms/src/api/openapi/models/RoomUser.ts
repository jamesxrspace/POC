/* tslint:disable */
/* eslint-disable */
/**
 * Server API - Login
 * The Restful APIs of Login.
 *
 * The version of the OpenAPI document: 1.0.0
 *
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 *
 * @export
 * @interface RoomUser
 */
export interface RoomUser {
  /**
   *
   * @type {string}
   * @memberof RoomUser
   */
  xrid: string;
}

/**
 * Check if a given object implements the RoomUser interface.
 */
export function instanceOfRoomUser(value: object): boolean {
  let isInstance = true;
  isInstance = isInstance && 'xrid' in value;

  return isInstance;
}

export function RoomUserFromJSON(json: any): RoomUser {
  return RoomUserFromJSONTyped(json, false);
}

export function RoomUserFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoomUser {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    xrid: json['xrid'],
  };
}

export function RoomUserToJSON(value?: RoomUser | null): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    xrid: value.xrid,
  };
}